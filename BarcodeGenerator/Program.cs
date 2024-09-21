using ZXing;
using ZXing.Common;
using SkiaSharp;


Console.Write("(1) Barkod Oluşturma\n(2) Barkod Okuma\nYapmak istediğiniz işlemi seçiniz: ");
int selection = int.Parse(Console.ReadLine());
if (selection == 1)
{
    Console.Write("Barkod metnini girin: ");
    string barcodeText = Console.ReadLine();
    GenerateBarcode(barcodeText, "barcode.png");
    Console.WriteLine("Barkod başarıyla oluşturuldu ve barcode.png dosyasına kaydedildi.");
}
else if (selection == 2)
{
    DecodeBarcode();
}
else
{
    Console.WriteLine("Geçersiz seçim.");
}

void GenerateBarcode(string content, string filePath)
{
    var writer = new BarcodeWriterPixelData
    {
        Format = BarcodeFormat.EAN_13,
        Options = new EncodingOptions
        {
            Width = 300,
            Height = 150,
            Margin = 10
        }
    };

    // Barkodun pixel verilerini oluştur (RGBA formatında)
    var pixelData = writer.Write(content);

    // SkiaSharp ile barkod resmi oluştur ve PNG olarak kaydet
    using (var bitmap = new SKBitmap(pixelData.Width, pixelData.Height, SKColorType.Bgra8888, SKAlphaType.Premul))
    {
        // Piksel verilerini bitmap'e manuel olarak yükle
        IntPtr ptr = bitmap.GetPixels();
        System.Runtime.InteropServices.Marshal.Copy(pixelData.Pixels, 0, ptr, pixelData.Pixels.Length);

        // Barkodu PNG olarak kaydet
        using (var image = SKImage.FromBitmap(bitmap))
        using (var data = image.Encode(SKEncodedImageFormat.Png, 100))
        using (var stream = File.OpenWrite(filePath))
        {
            data.SaveTo(stream);
        }
    }
}

void DecodeBarcode()
{
    var reader = new ZXing.SkiaSharp.BarcodeReader();
    var skBitmap = SKBitmap.Decode("barcode.png");
    var result = reader.Decode(skBitmap);
    Console.WriteLine(result);
}

