; Listing generated by Microsoft (R) Optimizing Compiler Version 19.38.33134.0 

include listing.inc

INCLUDELIB MSVCRTD
INCLUDELIB OLDNAMES

msvcjmc	SEGMENT
__EE542F3C_concurrencysal@h DB 01H
__352C5E21_sal@h DB 01H
__5AF994F6_vadefs@h DB 01H
__3204334A_vcruntime@h DB 01H
__1B0272D9_corecrt@h DB 01H
__44420885_corecrt_stdio_config@h DB 01H
__AB601D8D_corecrt_wstdio@h DB 01H
__C1EC35D3_stdio@h DB 01H
__BB16330F_corecrt_math@h DB 01H
__3BF2A406_math@h DB 01H
__2430A9FF_source@c DB 01H
msvcjmc	ENDS
PUBLIC	__local_stdio_printf_options
PUBLIC	_vfprintf_l
PUBLIC	printf
PUBLIC	GetCylinderVolume
PUBLIC	main
PUBLIC	__JustMyCode_Default
PUBLIC	??_C@_03PPOCCAPH@?$CFf?6@			; `string'
PUBLIC	__real@4000000000000000
PUBLIC	__real@40091eb851eb851f
PUBLIC	__real@4024000000000000
EXTRN	__imp___acrt_iob_func:PROC
EXTRN	__imp___stdio_common_vfprintf:PROC
EXTRN	_RTC_CheckStackVars:PROC
EXTRN	_RTC_InitBase:PROC
EXTRN	_RTC_Shutdown:PROC
EXTRN	__CheckForDebuggerJustMyCode:PROC
EXTRN	__GSHandlerCheck:PROC
EXTRN	__security_check_cookie:PROC
EXTRN	__security_cookie:QWORD
EXTRN	_fltused:DWORD
_DATA	SEGMENT
COMM	?_OptionsStorage@?1??__local_stdio_printf_options@@9@9:QWORD							; `__local_stdio_printf_options'::`2'::_OptionsStorage
_DATA	ENDS
;	COMDAT pdata
pdata	SEGMENT
$pdata$__local_stdio_printf_options DD imagerel $LN3
	DD	imagerel $LN3+44
	DD	imagerel $unwind$__local_stdio_printf_options
pdata	ENDS
;	COMDAT pdata
pdata	SEGMENT
$pdata$_vfprintf_l DD imagerel $LN3
	DD	imagerel $LN3+103
	DD	imagerel $unwind$_vfprintf_l
pdata	ENDS
;	COMDAT pdata
pdata	SEGMENT
$pdata$printf DD imagerel $LN3
	DD	imagerel $LN3+191
	DD	imagerel $unwind$printf
pdata	ENDS
;	COMDAT pdata
pdata	SEGMENT
$pdata$GetCylinderVolume DD imagerel $LN3
	DD	imagerel $LN3+90
	DD	imagerel $unwind$GetCylinderVolume
pdata	ENDS
;	COMDAT pdata
pdata	SEGMENT
$pdata$main DD	imagerel $LN3
	DD	imagerel $LN3+87
	DD	imagerel $unwind$main
pdata	ENDS
;	COMDAT __real@4024000000000000
CONST	SEGMENT
__real@4024000000000000 DQ 04024000000000000r	; 10
CONST	ENDS
;	COMDAT __real@40091eb851eb851f
CONST	SEGMENT
__real@40091eb851eb851f DQ 040091eb851eb851fr	; 3.14
CONST	ENDS
;	COMDAT __real@4000000000000000
CONST	SEGMENT
__real@4000000000000000 DQ 04000000000000000r	; 2
CONST	ENDS
;	COMDAT rtc$TMZ
rtc$TMZ	SEGMENT
_RTC_Shutdown.rtc$TMZ DQ FLAT:_RTC_Shutdown
rtc$TMZ	ENDS
;	COMDAT rtc$IMZ
rtc$IMZ	SEGMENT
_RTC_InitBase.rtc$IMZ DQ FLAT:_RTC_InitBase
rtc$IMZ	ENDS
;	COMDAT ??_C@_03PPOCCAPH@?$CFf?6@
CONST	SEGMENT
??_C@_03PPOCCAPH@?$CFf?6@ DB '%f', 0aH, 00H		; `string'
CONST	ENDS
;	COMDAT xdata
xdata	SEGMENT
$unwind$main DD	025050f01H
	DD	010a230fH
	DD	070030021H
	DD	05002H
xdata	ENDS
;	COMDAT xdata
xdata	SEGMENT
$unwind$GetCylinderVolume DD 035051a01H
	DD	0115331aH
	DD	0700e0023H
	DD	0500dH
xdata	ENDS
;	COMDAT voltbl
voltbl	SEGMENT
_volmd	DB	045H
	DB	0a6H
voltbl	ENDS
;	COMDAT xdata
xdata	SEGMENT
$unwind$printf DD 025054c19H
	DD	011d2322H
	DD	070160025H
	DD	05015H
	DD	imagerel __GSHandlerCheck
	DD	0118H
xdata	ENDS
;	COMDAT CONST
CONST	SEGMENT
printf$rtcName$0 DB 05fH
	DB	041H
	DB	072H
	DB	067H
	DB	04cH
	DB	069H
	DB	073H
	DB	074H
	DB	00H
	ORG $+7
printf$rtcVarDesc DD 048H
	DD	08H
	DQ	FLAT:printf$rtcName$0
	ORG $+48
printf$rtcFrameData DD 01H
	DD	00H
	DQ	FLAT:printf$rtcVarDesc
CONST	ENDS
;	COMDAT xdata
xdata	SEGMENT
$unwind$_vfprintf_l DD 035052201H
	DD	011d3322H
	DD	07016001fH
	DD	05015H
xdata	ENDS
;	COMDAT xdata
xdata	SEGMENT
$unwind$__local_stdio_printf_options DD 025050f01H
	DD	010a230fH
	DD	07003001dH
	DD	05002H
xdata	ENDS
; Function compile flags: /Odt
;	COMDAT __JustMyCode_Default
_TEXT	SEGMENT
__JustMyCode_Default PROC				; COMDAT
	ret	0
__JustMyCode_Default ENDP
_TEXT	ENDS
; Function compile flags: /Odtp /RTCsu /ZI
; File E:\Code\vs_c#\CsharpStudy\ExpressExample02\CApp\source.c
;	COMDAT main
_TEXT	SEGMENT
res$ = 8
main	PROC						; COMDAT

; 9    : int main() {

$LN3:
	push	rbp
	push	rdi
	sub	rsp, 264				; 00000108H
	lea	rbp, QWORD PTR [rsp+32]
	lea	rcx, OFFSET FLAT:__2430A9FF_source@c
	call	__CheckForDebuggerJustMyCode

; 10   : 	double res = GetCylinderVolume(2.00, 10.00);

	movsd	xmm1, QWORD PTR __real@4024000000000000
	movsd	xmm0, QWORD PTR __real@4000000000000000
	call	GetCylinderVolume
	movsd	QWORD PTR res$[rbp], xmm0

; 11   : 	printf("%f\n", res);

	movsd	xmm1, QWORD PTR res$[rbp]
	movq	rdx, xmm1
	lea	rcx, OFFSET FLAT:??_C@_03PPOCCAPH@?$CFf?6@
	call	printf

; 12   : 	return 0;

	xor	eax, eax

; 13   : }

	lea	rsp, QWORD PTR [rbp+232]
	pop	rdi
	pop	rbp
	ret	0
main	ENDP
_TEXT	ENDS
; Function compile flags: /Odtp /RTCsu /ZI
; File E:\Code\vs_c#\CsharpStudy\ExpressExample02\CApp\source.c
;	COMDAT GetCylinderVolume
_TEXT	SEGMENT
result$ = 8
r$ = 256
h$ = 264
GetCylinderVolume PROC					; COMDAT

; 4    : double GetCylinderVolume(const double r, const double h) {

$LN3:
	movsd	QWORD PTR [rsp+16], xmm1
	movsd	QWORD PTR [rsp+8], xmm0
	push	rbp
	push	rdi
	sub	rsp, 280				; 00000118H
	lea	rbp, QWORD PTR [rsp+48]
	lea	rcx, OFFSET FLAT:__2430A9FF_source@c
	call	__CheckForDebuggerJustMyCode

; 5    : 	double result = 3.14 * r * r * h;

	movsd	xmm0, QWORD PTR __real@40091eb851eb851f
	mulsd	xmm0, QWORD PTR r$[rbp]
	mulsd	xmm0, QWORD PTR r$[rbp]
	mulsd	xmm0, QWORD PTR h$[rbp]
	movsd	QWORD PTR result$[rbp], xmm0

; 6    : 	return result;

	movsd	xmm0, QWORD PTR result$[rbp]

; 7    : }

	lea	rsp, QWORD PTR [rbp+232]
	pop	rdi
	pop	rbp
	ret	0
GetCylinderVolume ENDP
_TEXT	ENDS
; Function compile flags: /Odtp /RTCsu /ZI
; File C:\Program Files (x86)\Windows Kits\10\Include\10.0.22621.0\ucrt\stdio.h
;	COMDAT printf
_TEXT	SEGMENT
_Result$ = 4
_ArgList$ = 40
__$ArrayPad$ = 248
_Format$ = 288
printf	PROC						; COMDAT

; 956  :     {

$LN3:
	mov	QWORD PTR [rsp+8], rcx
	mov	QWORD PTR [rsp+16], rdx
	mov	QWORD PTR [rsp+24], r8
	mov	QWORD PTR [rsp+32], r9
	push	rbp
	push	rdi
	sub	rsp, 296				; 00000128H
	lea	rbp, QWORD PTR [rsp+32]
	lea	rdi, QWORD PTR [rsp+32]
	mov	ecx, 18
	mov	eax, -858993460				; ccccccccH
	rep stosd
	mov	rcx, QWORD PTR [rsp+328]
	mov	rax, QWORD PTR __security_cookie
	xor	rax, rbp
	mov	QWORD PTR __$ArrayPad$[rbp], rax
	lea	rcx, OFFSET FLAT:__C1EC35D3_stdio@h
	call	__CheckForDebuggerJustMyCode

; 957  :         int _Result;
; 958  :         va_list _ArgList;
; 959  :         __crt_va_start(_ArgList, _Format);

	lea	rax, QWORD PTR _Format$[rbp+8]
	mov	QWORD PTR _ArgList$[rbp], rax

; 960  :         _Result = _vfprintf_l(stdout, _Format, NULL, _ArgList);

	mov	ecx, 1
	call	QWORD PTR __imp___acrt_iob_func
	mov	r9, QWORD PTR _ArgList$[rbp]
	xor	r8d, r8d
	mov	rdx, QWORD PTR _Format$[rbp]
	mov	rcx, rax
	call	_vfprintf_l
	mov	DWORD PTR _Result$[rbp], eax

; 961  :         __crt_va_end(_ArgList);

	mov	QWORD PTR _ArgList$[rbp], 0

; 962  :         return _Result;

	mov	eax, DWORD PTR _Result$[rbp]

; 963  :     }

	mov	edi, eax
	lea	rcx, QWORD PTR [rbp-32]
	lea	rdx, OFFSET FLAT:printf$rtcFrameData
	call	_RTC_CheckStackVars
	mov	eax, edi
	mov	rcx, QWORD PTR __$ArrayPad$[rbp]
	xor	rcx, rbp
	call	__security_check_cookie
	lea	rsp, QWORD PTR [rbp+264]
	pop	rdi
	pop	rbp
	ret	0
printf	ENDP
_TEXT	ENDS
; Function compile flags: /Odtp /RTCsu /ZI
; File C:\Program Files (x86)\Windows Kits\10\Include\10.0.22621.0\ucrt\stdio.h
;	COMDAT _vfprintf_l
_TEXT	SEGMENT
_Stream$ = 224
_Format$ = 232
_Locale$ = 240
_ArgList$ = 248
_vfprintf_l PROC					; COMDAT

; 644  :     {

$LN3:
	mov	QWORD PTR [rsp+32], r9
	mov	QWORD PTR [rsp+24], r8
	mov	QWORD PTR [rsp+16], rdx
	mov	QWORD PTR [rsp+8], rcx
	push	rbp
	push	rdi
	sub	rsp, 248				; 000000f8H
	lea	rbp, QWORD PTR [rsp+48]
	lea	rcx, OFFSET FLAT:__C1EC35D3_stdio@h
	call	__CheckForDebuggerJustMyCode

; 645  :         return __stdio_common_vfprintf(_CRT_INTERNAL_LOCAL_PRINTF_OPTIONS, _Stream, _Format, _Locale, _ArgList);

	call	__local_stdio_printf_options
	mov	rcx, QWORD PTR _ArgList$[rbp]
	mov	QWORD PTR [rsp+32], rcx
	mov	r9, QWORD PTR _Locale$[rbp]
	mov	r8, QWORD PTR _Format$[rbp]
	mov	rdx, QWORD PTR _Stream$[rbp]
	mov	rcx, QWORD PTR [rax]
	call	QWORD PTR __imp___stdio_common_vfprintf

; 646  :     }

	lea	rsp, QWORD PTR [rbp+200]
	pop	rdi
	pop	rbp
	ret	0
_vfprintf_l ENDP
_TEXT	ENDS
; Function compile flags: /Odtp /RTCsu /ZI
; File C:\Program Files (x86)\Windows Kits\10\Include\10.0.22621.0\ucrt\corecrt_stdio_config.h
;	COMDAT __local_stdio_printf_options
_TEXT	SEGMENT
__local_stdio_printf_options PROC			; COMDAT

; 90   :     {

$LN3:
	push	rbp
	push	rdi
	sub	rsp, 232				; 000000e8H
	lea	rbp, QWORD PTR [rsp+32]
	lea	rcx, OFFSET FLAT:__44420885_corecrt_stdio_config@h
	call	__CheckForDebuggerJustMyCode

; 91   :         static unsigned __int64 _OptionsStorage;
; 92   :         return &_OptionsStorage;

	lea	rax, OFFSET FLAT:?_OptionsStorage@?1??__local_stdio_printf_options@@9@9 ; `__local_stdio_printf_options'::`2'::_OptionsStorage

; 93   :     }

	lea	rsp, QWORD PTR [rbp+200]
	pop	rdi
	pop	rbp
	ret	0
__local_stdio_printf_options ENDP
_TEXT	ENDS
END
