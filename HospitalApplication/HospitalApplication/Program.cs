using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            int choice;
            var dbContext = new HospitalDbEntities();            
            while(flag)
            {
                Console.WriteLine("1. Add Patient Details");
                Console.WriteLine("2. Show Patient");
                Console.WriteLine("3. Add Doctor Details");
                Console.WriteLine("4. Show Doctor");
                Console.WriteLine("5. Add Assistant");
                Console.WriteLine("6. Add Drug");               
                Console.WriteLine("7. Add Appointment");
                Console.WriteLine("8. Add Precsription");
                Console.WriteLine("9. Exit");
                Console.WriteLine("Enter your Choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddPatient();
                        break;

                    case 2:
                        PatientList();                     
                        break;

                    case 3:
                        AddDoctor();                        
                        break;                   

                    case 4:
                        DoctorList();                        
                        break;

                    case 5:
                        AddAssistant();
                        break;

                    case 6:
                        AddDrug();
                        break;

                    case 7:
                        AddAppointment();
                        break;

                    case 8:
                        AddPrescription();
                        break;

                    case 9:
                        flag = false;
                        break;

                    default:
                        break;
                }

            }
            void AddPatient()
            {
                using (dbContext)
                {
                    var patient = new Patient();

                    Console.WriteLine("Enter Patient Name: ");
                    patient.Name = Console.ReadLine();

                    Console.WriteLine("Enter Patient Address: ");
                    patient.Address = Console.ReadLine();

                    Console.WriteLine("Enter Patient Age: ");
                    patient.Age = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Patient Gender: ");
                    patient.Gender = Console.ReadLine();

                    Console.WriteLine("Enter Patient Contact Number: ");
                    patient.ContactNo = Convert.ToInt64(Console.ReadLine());

                    //var check = dbContext.Patients.Where(t => t.Name == patient.name);
                    var check = dbContext.Patients.SingleOrDefault(t => t.Name == patient.Name);
                    if (check == null)
                    {
                        try
                        {
                            dbContext.Patients.Add(patient);
                            dbContext.SaveChanges();
                            Console.WriteLine("Patient added to the list");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Patient is already in the list");
                    }
                }
            }
            //void RemovePatient()
            //{
            //    using (dbContext)
            //    {
            //        Console.WriteLine("Enter Patient name to delete : ");
            //        string del = Console.ReadLine();
            //        var delPatient = dbContext.Patients.Where(t => t.Name == del);
            //        if (delPatient.Count() == 1)
            //        {
            //            try
            //            {
            //                dbContext.Patients.Remove(dbContext.Patients.Single(t => t.Name == del));
            //                dbContext.SaveChanges();
            //                Console.WriteLine("Patient is removed !!");
            //            }
            //            catch (Exception e)
            //            {
            //                Console.WriteLine(e);
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Patient is not available in the list");
            //        }
            //    }
            //}

            void AddDoctor()
            {
                using (dbContext)
                {
                    var doctor = new Doctor();

                    Console.WriteLine("Enter Doctor Name: ");
                    doctor.Name = Console.ReadLine();

                    Console.WriteLine("Enter Doctor Address: ");
                    doctor.Address = Console.ReadLine();

                    Console.WriteLine("Enter Doctor Gender: ");
                    doctor.Gender = Console.ReadLine();

                    Console.WriteLine("Enter Doctor Contact Number: ");
                    doctor.ContactNo = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Enter Doctor Designation: ");
                    doctor.Designation = Console.ReadLine();
                    
                    var check = dbContext.Doctors.SingleOrDefault(t => t.Name == doctor.Name);
                    if (check == null)
                    {
                        try
                        {
                            dbContext.Doctors.Add(doctor);
                            dbContext.SaveChanges();
                            Console.WriteLine("Doctor added to the list");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Doctor is already in the list");
                    }
                }
            }
           void AddDrug()
            {
                using (var dbContext1 = new HospitalDbEntities())
                {
                    var drug = new Drug();

                    Console.WriteLine("Enter Drug Name: ");
                    drug.Name = Console.ReadLine();

                    var check = dbContext1.Drugs.SingleOrDefault(t => t.Name == drug.Name);
                    if (check == null)
                    {
                        try
                        {
                            dbContext1.Drugs.Add(drug);
                            dbContext1.SaveChanges();
                            Console.WriteLine("Drug added to the list");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Drug is already in the list");
                    }
                }
            }
            //void RemoveDoctor()
            //{
            //    using (dbContext)
            //    {
            //        Console.WriteLine("Enter Doctor name to delete : ");
            //        string del = Console.ReadLine();
            //        var delDoctor = dbContext.Doctors.Where(t => t.Name == del);
            //        if (delDoctor.Count() == 1)
            //        {
            //            try
            //            {
            //                dbContext.Doctors.Remove(dbContext.Doctors.Single(t => t.Name == del));
            //                dbContext.SaveChanges();
            //                Console.WriteLine("Doctor is removed !!");
            //            }
            //            catch (Exception e)
            //            {
            //                Console.WriteLine(e);
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Doctor is not available in the list");
            //        }
            //    }
            //}

            void AddAssistant()
            {
                using (dbContext)
                {
                    var assistant = new Assistant();

                    Console.WriteLine("Enter Name: ");
                    assistant.Name = Console.ReadLine();

                    Console.WriteLine("Enter Address: ");
                    assistant.Address = Console.ReadLine();

                    Console.WriteLine("Enter Age: ");
                    assistant.Age = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Gender: ");
                    assistant.Gender = Console.ReadLine();

                    Console.WriteLine("Enter Contact Number: ");
                    assistant.ContactNo = Convert.ToInt64(Console.ReadLine());
                    
                    var check = dbContext.Assistants.SingleOrDefault(t => t.Name == assistant.Name);
                    if (check == null)
                    {
                        try
                        {
                            dbContext.Assistants.Add(assistant);
                            dbContext.SaveChanges();
                            Console.WriteLine("Assistant added to the list");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Assistant is already in the list");
                    }
                }
            }
           
            void AddAppointment()
            {
                using (dbContext)
                {
                    var appointment = new Appointment();

                    Console.WriteLine("Patients: ");
                    PatientList();
                    Console.WriteLine("Enter Patient Id : ");
                    appointment.PatientId = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Doctors : ");
                    DoctorList();
                    Console.WriteLine("Enter Doctor Id: ");
                    appointment.DoctorId = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Appointment Time: ");
                    appointment.AppointmentTime = Convert.ToDateTime(Console.ReadLine());

                    var check = dbContext.Appointments.SingleOrDefault(t => t.PatientId == appointment.PatientId);
                    if (check == null)
                    {
                        try
                        {
                            dbContext.Appointments.Add(appointment);
                            dbContext.SaveChanges();
                            Console.WriteLine("Appointment booked !!");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Appointment is already booked !!");
                    }
                }

            }
            void AddPrescription()
            {
                using (dbContext)
                {
                    var pm = new Prescription();

                    Console.WriteLine("Patients: ");
                    PatientList();
                    Console.WriteLine("Enter Patient Id : ");
                    pm.PatientId = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Assistants : ");
                    AssistantList();
                    Console.WriteLine("Enter Assistant Id: ");
                    pm.AssistantId = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Timing");
                    pm.Time = Console.ReadLine();

                    Console.WriteLine("Drug list: ");
                    DrugList();
                    Console.WriteLine("Enter Drug Id : ");
                    pm.DrugId = Convert.ToInt32(Console.ReadLine());                   

                    var check = dbContext.Prescriptions.SingleOrDefault(t => t.PatientId == pm.PatientId);
                    if (check == null)
                    {
                        try
                        {
                            dbContext.Prescriptions.Add(pm);
                            dbContext.SaveChanges();
                            Console.WriteLine("Prescription added !!");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Prescriptions are already in the list !!");
                    }
                }
            }
            void PatientList()
            {
                var db = new HospitalDbEntities();
                var patientList = db.Patients;
                try
                {
                    foreach (var p in patientList)
                    {
                        Console.WriteLine("Id: "+ p.PatientId + "Name : " + p.Name);
                    }                    
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            void DoctorList()
            {
                var db = new HospitalDbEntities();
                var doctorList = db.Doctors;
                try
                {
                    foreach (var d in doctorList)
                    {
                        Console.WriteLine("Id : "+ d.DoctorId +"Name : " + d.Name);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            void AssistantList()
            {
                var db = new HospitalDbEntities();
                var assistantList = db.Assistants;
                try
                {
                    foreach (var a in assistantList)
                    {
                        Console.WriteLine("Id: "+a.AssistantId + "Name : " + a.Name);
                    }                    
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            void DrugList()
            {
                var db = new HospitalDbEntities();
                var d = db.Drugs;
                try
                {
                    foreach (var a in d)
                    {
                        Console.WriteLine("Id: "+ a.DrugId + "Name : " + a.Name);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }

        }
    }
}
