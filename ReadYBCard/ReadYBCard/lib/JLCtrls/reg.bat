SET "SELFPATH=%~dp0"

regsvr32 /s "%SELFPATH%JLPrintEcg.ocx"
regsvr32 /s "%SELFPATH%JLEcgReview.ocx"
rem regsvr32 /s "%SELFPATH%JLEcgSample.ocx"
regsvr32 /s "%SELFPATH%JLVcgView.ocx"
regsvr32 /s "%SELFPATH%JLEcgDiagnose.ocx"
"%SELFPATH%regasm" "%SELFPATH%pdfecgconvert.dll"