Imports System.IO
Imports Aspose.Imaging.FileFormats.Tiff

Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages
    Public Class ConcatTIFFImages
        Public Shared Sub Run()
            ' To get proper output please apply a valid Aspose.Imaging License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.")
            ' ExStart:ConcatTIFFImages
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ModifyingAndConvertingImages()

            ' Create a copy of original image to avoid any alteration
            File.Copy(dataDir & Convert.ToString("demo.tif"), dataDir & Convert.ToString("TestDemo.tif"), True)

            ' Create an instance of TiffImage and load the copied destination image
            Using image__1 As TiffImage = DirectCast(Image.Load(dataDir & Convert.ToString("TestDemo.tif")), TiffImage)
                ' Create an instance of TiffImage and load the source image
                Using image1 As TiffImage = DirectCast(Image.Load(dataDir & Convert.ToString("sample.tif")), TiffImage)
                    ' Create an instance of TIffFrame and copy active frame of source image
                    Dim frame As TiffFrame = TiffFrame.CopyFrame(image1.ActiveFrame)

                    ' Add copied frame to destination image
                    image__1.AddFrame(frame)

                    ' save the image with changes.
                    image__1.Save(dataDir & Convert.ToString("ConcatTIFFImages_out.tiff"))
                End Using
            End Using
            ' ExEnd:ConcatTIFFImages
            ' Display Status.
            Console.WriteLine("Concatenation of TIF files done successfully.")
        End Sub
    End Class
End Namespace