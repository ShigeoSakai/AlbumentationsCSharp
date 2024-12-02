import numpy as np
import albumentations as A
import cv2
import os
import sys
from copy import deepcopy
import warnings

# 警告を表示しない
warnings.simplefilter('ignore')

#
# 日本語対応imread
#
def imread(filename, flags=cv2.IMREAD_COLOR, dtype=np.uint8):
	try:
		n = np.fromfile(filename, dtype)
		img = cv2.imdecode(n, flags)
		return img
	except Exception as e:
		print('## imread:',e,file=sys.stderr)
	return None

#
# 日本語対応imwrite
#
def imwrite(filename, img, params=None):
	try:
		ext = os.path.splitext(filename)[1]
		result, n = cv2.imencode(ext, img, params)
        
		if result:
			with open(filename, mode='w+b') as f:
				n.tofile(f)
				return True
		else:
			return False
	except Exception as e:
		print('## imwrite:',e,file=sys.stderr)
		return False

#
# BGR→RGB変換
#
def Bgr2Rgb(img) :
	if img is not None:
		if img.ndim == 2 :
			# Gray
			pass
		elif img.shape[2] == 3:
			# BGR
			img = cv2.cvtColor(img, cv2.COLOR_BGR2RGB)
		elif img.shape[2] == 4:
			# BGRA
			img = cv2.cvtColor(img, cv2.COLOR_BGRA2RGB)
	return img

#
# RGB→BGR変換
#
def Rgb2Bgr(img) :
	if img is not None:
		if img.ndim == 2 :
			# Gray
			pass
		elif img.shape[2] == 3:
			# RGB
			img = cv2.cvtColor(img, cv2.COLOR_RGB2BGR)
		elif img.shape[2] == 4:
			# RGBA
			img = cv2.cvtColor(img, cv2.COLOR_RGBA2BGRA)
	return img

#
# Albumentations実行
#
def trans_exec(
	trans,img,img_filename,
	mask = None, mask_filename = None,
	bbox = None , bbox_label = None, bbox_filename = None,
	keypoints = None , keypoints_label = None, keypoints_filename = None):

	src_img = deepcopy(img)
	if mask is not None:
		src_mask = deepcopy(mask)

	# 結果画像ファイルを削除
	if (img_filename is not None) and (os.path.isfile(img_filename)) :
		os.remove(img_filename)
	if (mask_filename is not None) and (os.path.isfile(mask_filename)) :
		os.remove(mask_filename)
	# 結果データファイルを削除
	if (bbox_filename is not None) and (os.path.isfile(bbox_filename)) :
		os.remove(bbox_filename)
	if (keypoints_filename is not None) and (os.path.isfile(keypoints_filename)) :
		os.remove(keypoints_filename)

	if trans is not None:
		args = "(image=src_img"
		if mask is not None:
			args += ",mask=src_mask"
		if bbox is not None:
			args += ",bboxes=bbox"
		if bbox_label is not None:
			args += ",bbox_label=bbox_label"
		if keypoints is not None:
			args += ",keypoints=keypoints"
		if keypoints_label is not None:
			args += ",keypoints_label=keypoints_label"
		args += ")"
		trans_cmd = "trans" + args

		# コマンドを実行
		try:
			results = eval(trans_cmd)
		except Exception as e:
			print('## Albumentations:',e,file=sys.stderr)
			return
		
		# 結果
		if results is not None:
			result_bbox = None
			result_bbox_label = None
			result_keypoints = None
			result_keypoints_label = None
			for key in results.keys():
				if key == 'image' :
					# 結果画像を保存
					if (results['image'] is not None) and (img_filename is not None):
						imwrite(img_filename,Rgb2Bgr(results['image']))
				elif key == 'mask':
					# 結果マスク画像を保存
					if (results['mask'] is not None) and (mask_filename is not None):
						imwrite(mask_filename,Rgb2Bgr(results['mask']))
				elif key == 'bboxes':
					result_bbox = results['bboxes']
				elif key == 'bbox_label':
					result_bbox_label = results['bbox_label']
				elif key == 'keypoints':
					result_keypoints = results['keypoints']
				elif key == 'keypoints_label':
					result_keypoints_label = results['keypoints_label']
			# BBOXを保存
			if (result_bbox is not None) and (bbox_filename is not None):
				with open(bbox_filename,mode='w') as f:
					for i in range(len(result_bbox)):
						label = ''
						if (result_bbox_label is not None) and (i < len(result_bbox_label)):
							label = result_bbox_label[i]
						f.write(label + ',' + 
							str(result_bbox[i][0]) + ',' + 
							str(result_bbox[i][1]) + ',' +
							str(result_bbox[i][2]) + ',' +
							str(result_bbox[i][3]) + '\n')
			# KeyPointsを保存
			if (result_keypoints is not None) and (keypoints_filename is not None):
				with open(keypoints_filename,mode='w') as f:
					for i in range(len(result_keypoints)):
						label = ''
						if (result_keypoints_label is not None) and (i < len(result_keypoints_label)):
							label = result_keypoints_label[i]
						f.write(label + ',' + 
							str(result_keypoints[i][0]) + ',' + 
							str(result_keypoints[i][1]) + '\n')


# 入力画像
img = None
# マスク画像
mask = None
# BBOX
bboxes = None
# BBoxラベル
bbox_label = None
# keypoints
keypoints = None
# keypointsラベル
keypoints_label = None

# 変換
transform = None

# 画像保存ファイル名
result_img_filename = "result.bmp"
# マスク画像保存ファイル名
mask_img_filename = "mask.bmp"
# BBox結果ファイル
result_bbox_filename = "bbox.csv"
# keypoints結果ファイル
result_keypoints_filename = "keypoints.csv"


# バージョンを応答
print("> ",A.__version__, flush=True)

while True:
	print(">", flush=True)
	text = input()
	# 終了
	if text.upper().startswith("END") :
		break;
	if text.upper().startswith("EXIT") :
		break;
	if text.upper().startswith("QUIT") :
		break;

	# 画像ファイル読み込み
	if text.upper().startswith("IMG:") :
		if len(text) == 4:
			# 画像の消去	
			img = None
		else :
			# 画像の読み込み
			img_filename = text[4:]
			if os.path.isfile(img_filename) :
				img = Bgr2Rgb(imread(img_filename))

	if text.upper().startswith("IMG!") :
		if img is not None :
			print(img.shape)
		else :
			print('img is null')

	# マスク画像読み込み
	if text.upper().startswith("MASK:") :
		if len(text) == 5:
			# マスク画像の消去
			mask = None
		else:
			# マスク画像の読み込み
			mask_filename = text[5:]
			if os.path.isfile(mask_filename) :
				mask = Bgr2Rgb(imread(mask_filename))

	if text.upper().startswith("MASK!") :
		if mask is not None:
			print(mask.shape)
		else:
			print('mask is null')

	# Transform指定
	if text.upper().startswith("TR:") :
		if len(text) == 3 :
			# Transform削除
			transform = None
		else :
			# 入力文字をtransformに代入する文字列を作成
			tr_str = "transform =" + text[3:]
			# Exec()を呼び出し、transformに代入
			exec(tr_str)
			# 実際にtransformを実行する
			trans_exec(transform,img,result_img_filename,mask,mask_img_filename,
				bboxes,bbox_label,result_bbox_filename,
				keypoints,keypoints_label,result_keypoints_filename)

	if text.upper().startswith("TR!") :
		print(transform)

	# 保存ファイル名
	if text.upper().startswith("SF:") :
		if len(text) == 3:
			print('Save Image Filename:',result_img_filename)
		else :
			result_img_filename = text[3:]

	if text.upper().startswith("MF:") :
		if len(text) == 3:
			print('Save Mask Filename:',mask_img_filename)
		else :
			mask_img_filename = text[3:]
	if text.upper().startswith("SB:") :
		if len(text) == 3:
			print('Save BBox Filename:',result_bbox_filename)
		else :
			result_bbox_filename = text[3:]
	if text.upper().startswith("SK:") :
		if len(text) == 3:
			print('Save KeyPoints Filename:',result_keypoints_filename)
		else :
			result_keypoints_filename = text[3:]



	# BBOX
	if text.upper().startswith("BBOX:") :
		if len(text) == 5:
			bboxes = None
			bbox_label = None
		else :
			bbox_str = "bboxes = " + text[5:]
			exec(bbox_str)
	if text.upper().startswith("BBOX!") :
		if bboxes is None:
			print('BBox is None')
		else :
			print('BBox:',bboxes)

	# BBOXラベル
	if text.upper().startswith("LBOX:") :
		if len(text) == 5:
			bbox_label = None
		else :
			lbox_str = "bbox_label = " + text[5:]
			exec(lbox_str)
	if text.upper().startswith("LBOX!") :
		if bbox_label is None:
			print('BBox Label is None')
		else :
			print('BBox Label:',bbox_label)

	# KeyPpints
	if text.upper().startswith("KP:") :
		if len(text) == 3:
			keypoints = None
			keypoints_label = None
		else :
			kp_str = "keypoints = " + text[3:]
			exec(kp_str)
	if text.upper().startswith("KP!") :
		if keypoints is None:
			print('Keypoints is None')
		else :
			print('Keypoints:',keypoints)

	# KeyPpintsラベル
	if text.upper().startswith("LKP:") :
		if len(text) == 4:
			keypoints_label = None
		else :
			lkp_str = "keypoints_label = " + text[4:]
			exec(lkp_str)
	if text.upper().startswith("LKP!") :
		if keypoints_label is None:
			print('Keypoints Label is None')
		else :
			print('Keypoints Label:',keypoints_label)
