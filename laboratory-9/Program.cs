namespace hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Система управления больницей");

            Hospital hospital = new Hospital(1, "городская больница", "ул. Питерская 3");

            Doctor doc1 = new Doctor(1, "Вася", "Иванов", "Хирургия");
            Doctor doc2 = new Doctor(2, "Женя", "Женев", "Кардиология");

            Cardiology card = new Cardiology(101, "Кардиология", doc1, 20);
            Surgery surg = new Surgery(102, "Хирургия", doc2, 15);

            hospital.AddDepartment(101);
            hospital.AddDepartment(102);

            Patient pat1 = new Patient(1, "Оля", "Пупкина", new DateTime(1990, 5, 15), "сердечный приступ");
            Patient pat2 = new Patient(2, "Катя", "Катина", new DateTime(1985, 8, 22), "лишай");

            doc1.AddPatient(pat1);
            doc2.AddPatient(pat2);

            card.AddDoctor(doc1);
            surg.AddDoctor(doc2);

            Console.WriteLine($"\nБольница: {hospital.Name}");
            Console.WriteLine($"Адрес: {hospital.Address}");
            Console.WriteLine($"Врачей в кардиологии: {card.GetDoctorsCount()}");
            Console.WriteLine($"Возраст пациента {pat1.FirstName}: {pat1.GetAge()}");
            Console.WriteLine($"Свободные койки в хирургии: {surg.GetAvailableBeds()}");
        }
    }
}
