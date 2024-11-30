import numpy as np
import albumentations as A
import cv2
import os
import sys
from copy import deepcopy
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
def trans_exec(trans,img,img_filename,mask = None, mask_filename = None):
	print(trans)

	src_img = deepcopy(img)
	if mask is not None:
		src_mask = deepcopy(mask)

	# 結果画像ファイルを削除
	if (img_filename is not None) and (os.path.isfile(img_filename)) :
		os.remove(img_filename)
	if (mask_filename is not None) and (os.path.isfile(mask_filename)) :
		os.remove(mask_filename)

	if trans is not None:
		if mask is None:
			try:
				dst_img = trans(image=src_img)['image']
			except Exception as e:
				print('## Albumentations:',e,file=sys.stderr)
			else :
				if dst_img is not None :
					imwrite(img_filename,Rgb2Bgr(dst_img))
		else :
			try:
				augmented = trans(image=src_img, mask=src_mask)
			except Exception as e:
				print('## Albumentations:',e,file=sys.stderr)
			else :
				dst_img, dst_mask = augmented['image'], augmented['mask']
				if dst_img is not None :
					imwrite(img_filename,Rgb2Bgr(dst_img))
				if dst_mask is not None and mask_filename is not None:
					imwrite(mask_filename,Rgb2Bgr(dst_mask))

# 入力画像
img = None
# マスク画像
mask = None
# 変換
transform = None
# 画像保存ファイル名
result_img_filename = "result.bmp"
# マスク画像保存ファイル名
mask_img_filename = "mask.bmp"

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
			trans_exec(transform,img,result_img_filename,mask,mask_img_filename)

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
