int countNumber = int.Parse(Console.ReadLine());
double averageGrade = 0;
double sumOfGrades = 0;
for (int i = 1; i <= countNumber; i++)
{
    double grade = double.Parse(Console.ReadLine());
    if (grade > 0)
    {
        sumOfGrades = sumOfGrades + grade;
    }
    averageGrade = sumOfGrades/countNumber;
}
Console.WriteLine($"{averageGrade:F2}");