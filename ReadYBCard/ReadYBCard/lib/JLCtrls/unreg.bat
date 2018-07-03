SET "SELFPATH=%~dp0"

regsvr32 /u /s "%SELFPATH%JLPrintEcg.ocx"
regsvr32 /u /s "%SELFPATH%JLEcgReview.ocx"
regsvr32 /u /s "%SELFPATH%JLEcgSample.ocx"
regsvr32 /u /s "%SELFPATH%JLVcgView.ocx"
regsvr32 /u /s "%SELFPATH%JLEcgDiagnose.ocx"
"%SELFPATH%regasm" /u "%SELFPATH%pdfecgconvert.dll"