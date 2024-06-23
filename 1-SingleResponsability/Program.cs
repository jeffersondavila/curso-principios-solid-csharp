using SingleResponsability;

ExportHelper exportHelper = new();
StudentRepository studentRepository = new();

exportHelper.ExportStudent(studentRepository.GetAll());

Console.WriteLine("Proceso Completado");