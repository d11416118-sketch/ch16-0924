using System;

class Program
{
    static void Main()
    {
        // 輸入體重
        Console.Write("請輸入體重 (公斤)：");
        string weightInput = Console.ReadLine();
        double weight = Convert.ToDouble(weightInput);

        // 輸入身高（公分）
        Console.Write("請輸入身高 (公分)：");
        string heightCmInput = Console.ReadLine();
        double heightCm = Convert.ToDouble(heightCmInput);

        // 換算為公尺
        double heightM = heightCm / 100;

        // 計算 BMI（體重除以身高的平方）
        double bmi = weight / (heightM * heightM);

        // 顯示 BMI 結果
        Console.WriteLine($"你的 BMI 是：{bmi:F2}");
    }
}
