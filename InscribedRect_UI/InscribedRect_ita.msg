; ****************************************************************************
;					(C) Copyright OMRON CORPORATION 2005-2013
;							All Rights Reserved
; ----------------------------------------------------------------------------
;						 ProcItem Italian Message
; ****************************************************************************

Title=Inscribed Rectangle

Expression=Judge JG;Mode MD;Max angle MAXANG;X1 x1;Y1 y1;X2 x2;Y2 y2;X3 x3;Y3 y3;X4 x4;Y4 y4;Area AR;Width WT;Height HT;CenterX CX;CenterY CY;

;*******************************************
;*** Titles (names) ************************
;*******************************************

DataTitle_judge=Judge
DataTitle_overallJudge=Overall Judgement

DataTitle_mode=Mode
DataTitle_max_angle=Max angle

DataTitle_m01angleSkip=Angle skip
DataTitle_m02angleSkip=Angle skip
DataTitle_m02scaleStep=Scale skip

DataTitle_x1=X1
DataTitle_y1=Y1
DataTitle_x2=X2
DataTitle_y2=Y2
DataTitle_x3=X3
DataTitle_y3=Y3
DataTitle_x4=X4
DataTitle_y4=Y4

DataTitle_area=Area
DataTitle_width=Width
DataTitle_height=Height
DataTitle_center_x=Center X
DataTitle_center_y=Center Y

;*******************************************
;*** Info (description) ********************
;*******************************************

DataInfo_judge=0: No judgement(unmeasured) 1: Judgement result OK -1: Judgement result NG -10: Error(image format mismatch) -11: Error(unregistered model) -12: Error(insufficient memory) -20: Error(other errors)
DataInfo_overallJudge=0: Reflect ON, 1: Reflect OFF

DataInfo_mode=0: Non Convex Poly, 1: Scale and Rotate Rectangle
DataInfo_max_angle=Angle range in [0; 90]

DataInfo_m01angleSkip=Skip angle range in [0; 90]
DataInfo_m02angleSkip=Skip angle range in [0; 90]
DataInfo_m02scaleStep=Scale step [0.01; 0.99]

DataInfo_x1=0 ... 32767 px
DataInfo_y1=0 ... 32767 px
DataInfo_x2=0 ... 32767 px
DataInfo_y2=0 ... 32767 px
DataInfo_x3=0 ... 32767 px
DataInfo_y3=0 ... 32767 px
DataInfo_x4=0 ... 32767 px
DataInfo_y4=0 ... 32767 px

DataInfo_area=0 ... 999999 px
DataInfo_width=0 ... 32767 px
DataInfo_height=0 ... 32767 px
DataInfo_center_x=0 ... 32767 px
DataInfo_center_y=0 ... 32767 px


;****************************
;*** For flow editing screen TDM
;*** Dropdowns, limits on inputs.
;****************************

Flow_OFF=OFF
Flow_ON=ON
Flow_MODE01=Mode01: Non Convex Poly
Flow_MODE02=Mode02: Scale and Rotate Rectangle

