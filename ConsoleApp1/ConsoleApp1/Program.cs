using System;

class Program
{
    static void Main()
    {
        // 輸入體重
        Console.Write("請輸入體重 (公斤)：");
        string weightInput = Console.ReadLine();
        double weight = Convert.ToDouble(weightInput);

        // 輸入身高
        Console.Write("請輸入身高 (公尺)：");
        string heightInput = Console.ReadLine();
        double height = Convert.ToDouble(heightInput);

        // 計算 BMI（體重除以身高的平方）
        double bmi = weight / (height * height);

        // 顯示 BMI 結果
        Console.WriteLine($"你的 BMI 是：{bmi:F2}");
    }
}
