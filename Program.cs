using System.Collections;
internal class Program{
  static Array Union(Array a, Array b){
    Array U = Array.CreateInstance(typeof(int),a.Length +b.Length);
    int index = 0;
    foreach (int v in a)
      U.SetValue (v, index ++);
    for (int i = b.GetLowerBound(0); i<=b.GetUpperBound(0); i++)
    for (int j = a.GetLowerBound(0); j<=a.GetUpperBound(0); j++)
    {
      if ((int)b.GetValue(i) == (int)a.GetValue(j))
        break;
      if (b.GetValue(i) != a.GetValue(j) && j == a.GetUpperBound(0))
        U.SetValue(b.GetValue(i), index++);
    }
    Array result =Array.CreateInstance(typeof(int), index);
    for (int i = 0; i< index; i++)
      result.SetValue(U.GetValue(i),i);
    return result;
  }
  static Array Intersection(Array a, Array b){
    int count = 0;
    Array c = Array.CreateInstance(typeof(int), Math.Min(a.Length, b.Length));
    for (int i = a.GetLowerBound(0); i<=a.GetUpperBound(0); i++){
      for (int j = b.GetLowerBound(0); j<=b.GetUpperBound(0); j++){
        if (a.GetValue(i).Equals(b.GetValue(j)))
          c.SetValue(a.GetValue(i), count++);
      }
    }
    Array result = Array.CreateInstance(typeof(int), count);
    for(int i = 0; i< count; i++)
      result.SetValue(c.GetValue(i), i);
    return result;
  }
  static Array Subtraction(Array a, Array b){
    Array v = Array.CreateInstance(typeof(int),a.Length);
    int index = 0;
    for (int i = a.GetLowerBound(0); i<=a.GetUpperBound(0);i++){
      for (int j = b.GetLowerBound(0); j<=b.GetUpperBound(0);j++){
        if ((int)a.GetValue(i) == (int)b.GetValue(j))
          break;
        if ((int)a.GetValue(i)!= (int)b.GetValue(j) && j == b.GetUpperBound(0))
          v.SetValue(a.GetValue(i), index++);
      }
    }
    Array result = Array.CreateInstance(typeof(int), index);
    for(int i = 0; i< index; i++)
      result.SetValue(v.GetValue(i), i);
    return result;
  }
  static List<int> Union(List<int> a, List<int> b){
    List<int> U = new List<int>();
    foreach (int v in a)
      U.Add(v);
    for (int i = 0; i<b.Count; i++)
      for (int j = 0; j<a.Count; j++)
      {
        if (b[i] == a[j])
          break;
        if (b[i] != a[j] && j == a.Count-1)
          U.Add(b[i]);
      }
    return U;
  }
  static List<int> Intersection(List<int> a, List<int> b){
    return null;
  }
  static List<int> Subtraction(List<int> a, List<int> b){
    return null;
  }
  static ArrayList Union(ArrayList a, ArrayList b){
    return null;
  }
  static ArrayList Intersection(ArrayList a, ArrayList b){
    return null;
  }
  static ArrayList Subtraction(ArrayList a, ArrayList b){
    return null;
  }
  static void Print(object x, string s){
    Console.WriteLine("\n" + s + ": ");
    foreach(int v in (dynamic)x)
      Console.Write(v + " ");
  }
  private static void Main(string[] args)
  {
    Random rand = new Random();
    /*Array ar = Array.CreateInstance(typeof(int), 
                          new int[]{5}, new int[]{1});
    //ar[1], ar[2], ar[3], ar[4], ar[5]
    //ar.SetValue(gtri, chi_so) <=> a[chi_so] = gtri
    //ar.GetValue(chi_so) <=> a[chi_so]
    for(int i=ar.GetLowerBound(0); i<=ar.GetUpperBound(0); i++)
      ar.SetValue(rand.Next(9, 99), i); 
    foreach(int v in ar)
      Console.Write(v + " ");

    Array ar2 = Array.CreateInstance(typeof(int), 
                          new int[]{2, 3}, new int[]{1, 1});
    for(int i=ar2.GetLowerBound(0);i<=ar2.GetUpperBound(0);i++)
      for(int j=ar2.GetLowerBound(1);j<=ar2.GetUpperBound(1);j++)
        ar2.SetValue(rand.Next(9, 99), i, j);
    Console.WriteLine();
    for(int i=ar2.GetLowerBound(0);i<=ar2.GetUpperBound(0);i++){
      for(int j=ar2.GetLowerBound(1);j<=ar2.GetUpperBound(1);j++)
        Console.Write("{0, 3}", ar2.GetValue(i, j));
      Console.WriteLine();
    }*/
    Array aA = Array.CreateInstance(typeof(int), 3);
    Array aB = Array.CreateInstance(typeof(int), 2);
    aA.SetValue(9, 0); aA.SetValue(7, 1); aA.SetValue(11, 2);
    aB.SetValue(7, 0); aB.SetValue(15, 1);
    Array aunion = Union(aA, aB);
    Array aintersection = Intersection(aA, aB);
    Array asubtraction = Subtraction(aA, aB);
    Print(aunion, "Array Union");
    Print(aintersection, "Array Intersection");
    Print(asubtraction, "Array Subtraction");

    List<int> lA = new List<int>{9, 7, 11};
    List<int> lB = new List<int>{7, 15};
    List<int> lunion = Union(lA, lB);
    Print(lunion, "List Union");
  }
}