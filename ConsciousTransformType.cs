# C-Simples

namespace DemoCSharp1
{
  class ConsciousTransformType {
    public static void ConsciousTransform() {
      int num = 12; string value = num.ToString();
      int i = 256; byte b; byte c; 
      checked { b = (byte)i;
      unchecked { c = (byte)i; // Burayı kontrol etmez } 
      }
    Console.WriteLine(b); }

  }
}
