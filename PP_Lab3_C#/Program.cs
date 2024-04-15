class Program
{
    static void Main()
    {
        Student[] students = [
            new Student("Пупкин", "Василий", "Васильевич", "23ИТ12", [3, 5, 5, 3, 4]),
            new Student("Белесов", "Матвей", "Евгеньевич", "21ИТ17", [5, 5, 5, 5, 5]),
            new Student("Косов", "Олег", "Анантольевич", "22ИТ16", [5, 5, 1, 5, 5]),
            new Student("Александров", "Александр", "Александрович", "23ИТ12", [2, 2, 5, 2, 4]),
            new Student("Павлов", "Максим", "Петрович", "21ИТ35", [5, 4, 4, 3, 3]),
            new Student("Павлюк", "Анатолий", "Иванович", "23ИТ34", [2, 3, 5, 2, 3]),
            new Student("Антипов", "Антип", "Петрович", "21ИТ14", [4, 4, 5, 3, 5])
        ];
        selectionSort(students);
        for (int i = 0; i < students.Length; i++)
        {
            Console.WriteLine($"{students[i].Surname}, {students[i].Name}, {students[i].Patronymic}, {students[i].GroupNumber}, {students[i].Mean()}");
        }
    }

    static void selectionSort(Student[] sortArr)
    {
        for (int i = 0; i < sortArr.Length; i++)
        {
            int min_id = i;
            Student min = sortArr[i];
            for (int j = i + 1; j < sortArr.Length; j++)
            {
                if (sortArr[j].Mean() < min.Mean())
                {
                    min_id = j;
                    min = sortArr[j];
                }
            }
            sortArr[min_id] = sortArr[i];
            sortArr[i] = min;
        }
    }
}

struct Student
{
    public string Surname;
    public string Name;
    public string Patronymic;
    public string GroupNumber;
    public int[] Performances;

    public Student(string surname, string name, string patronymic, string groupNumber, int[] performances)
    {
        this.Surname = surname;
        this.Name = name;
        this.Patronymic = patronymic;
        this.GroupNumber = groupNumber;
        this.Performances = performances;
    }

    public double Mean()
    {
        return Performances.Average();
    }
}