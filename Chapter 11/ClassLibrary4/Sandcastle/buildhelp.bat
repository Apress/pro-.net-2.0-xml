MRefBuilder Calculator.dll /out:reflection.org
XslTransform /xsl:..\..\ProductionTransforms\AddOverloads.xsl reflection.org /xsl:..\..\ProductionTransforms\AddGuidFilenames.xsl /out:reflection.xml
XslTransform /xsl:..\..\ProductionTransforms\ReflectionToManifest.xsl  reflection.xml /out:manifest.xml
call ..\..\Presentation\vs2005\copyOutput.bat
BuildAssembler /config:sandcastle.config manifest.xml
XslTransform /xsl:..\..\ProductionTransforms\ReflectionToChmProject.xsl reflection.xml /out:Output\Calculator.hhp
XslTransform /xsl:..\..\ProductionTransforms\ReflectionToChmContents.xsl reflection.xml /arg:html=Output\html /out:Output\Calculator.hhc
XslTransform /xsl:..\..\ProductionTransforms\ReflectionToChmIndex.xsl reflection.xml /out:Output\Calculator.hhk
