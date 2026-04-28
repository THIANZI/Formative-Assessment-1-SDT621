using System;
using System.Collections.Generic;
using System.Linq;

namespace EmfuleniMunicipality
{
    public class Resident
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string AccountNumber { get; set; }
        public double MonthlyUtilityUsage { get; set; }

        public Resident(string name, string address, string accountNumber, double monthlyUtilityUsage)
        {
            Name = name;
            Address = address;
            AccountNumber = accountNumber;
            MonthlyUtilityUsage = monthlyUtilityUsage;
        }
    }

    public class ServiceRequest
    {
        public Resident AssociatedResident { get; set; }
        public string RequestType { get; set; }
        public int PriorityLevel { get; set; }
        public int SeverityLevel { get; set; }
        public double EstimatedResolutionHours { get; set; }
        public bool IsProcessed { get; set; }
        public double UrgencyScore { get; private set; }

        public ServiceRequest(Resident resident, string requestType, int priorityLevel,
                              int severityLevel, double estimatedResolutionHours)
        {
            AssociatedResident = resident;
            RequestType = requestType;
            PriorityLevel = priorityLevel;
            SeverityLevel = severityLevel;
            EstimatedResolutionHours = estimatedResolutionHours;
            IsProcessed = false;
            UrgencyScore = 0;
        }

        public void SetUrgencyScore(double score)
        {
            UrgencyScore = score;
        }
    }

    public class UtilitiesManager
    {
        private List<ServiceRequest> serviceRequests;
        private List<ServiceRequest> processedRequests;

        public UtilitiesManager()
        {
            serviceRequests = new List<ServiceRequest>();
            processedRequests = new List<ServiceRequest>();
        }

        public void AddServiceRequest(ServiceRequest request)
        {
            serviceRequests.Add(request);
            CalculateUrgencyScore(request);
        }

        public void CalculateUrgencyScore(ServiceRequest request)
        {
            double urgencyScore = request.PriorityLevel * request.SeverityLevel * (request.EstimatedResolutionHours / 10.0);
            request.SetUrgencyScore(urgencyScore);
        }

        public List<ServiceRequest> GetPendingRequests()
        {
            return serviceRequests.Where(r => !r.IsProcessed).ToList();
        }

        public ServiceRequest SelectRequestToProcess(int index)
        {
            var pending = GetPendingRequests();
            if (index >= 0 && index < pending.Count)
            {
                return pending[index];
            }
            return null;
        }

        public void ProcessRequest(ServiceRequest request, double adjustedResolutionHours)
        {
            if (request != null && !request.IsProcessed)
            {
                request.IsProcessed = true;
                processedRequests.Add(request);
                GenerateServiceReport(request, adjustedResolutionHours);
            }
        }

        public void GenerateServiceReport(ServiceRequest request, double adjustedResolutionHours)
        {
            double householdImpactScore = request.AssociatedResident.MonthlyUtilityUsage * request.SeverityLevel;

            Console.WriteLine("\n=== Service Report ===");
            Console.WriteLine($"Resident: {request.AssociatedResident.Name}");
            Console.WriteLine($"Service Type: {request.RequestType}");
            Console.WriteLine($"Urgency Score: {request.UrgencyScore:F0}");
            Console.WriteLine($"Adjusted Resolution: {adjustedResolutionHours:F0} hours");
            Console.WriteLine($"Household Impact Score: {householdImpactScore:F2}");
        }

        public void DisplayPendingQueue()
        {
            var pending = GetPendingRequests();
            if (pending.Count == 0)
            {
                return;
            }

            Console.WriteLine("\n=== Pending Service Requests Queue ===");
            for (int i = 0; i < pending.Count; i++)
            {
                var request = pending[i];
                Console.WriteLine($"[{i + 1}] Resident: {request.AssociatedResident.Name} | " +
                                $"Type: {request.RequestType} | " +
                                $"Urgency Score: {request.UrgencyScore:F2}");
            }
        }

        public void GenerateFinalSummary()
        {
            if (processedRequests.Count == 0)
            {
                return;
            }

            var highestUrgencyRequest = processedRequests.OrderByDescending(r => r.UrgencyScore).First();

            Console.WriteLine("\n=== FINAL MUNICIPAL SUMMARY ===");
            Console.WriteLine("Highest priority issue:");
            Console.WriteLine($"Resident: {highestUrgencyRequest.AssociatedResident.Name}");
            Console.WriteLine($"Service Type: {highestUrgencyRequest.RequestType}");
            Console.WriteLine($"Urgency Score: {highestUrgencyRequest.UrgencyScore:F0}");

            double adjustedResolution = highestUrgencyRequest.EstimatedResolutionHours * (highestUrgencyRequest.UrgencyScore / 100);
            Console.WriteLine($"Adjusted Resolution: {adjustedResolution:F0} hours");

            double householdImpactScore = highestUrgencyRequest.AssociatedResident.MonthlyUtilityUsage * highestUrgencyRequest.SeverityLevel;
            Console.WriteLine($"Household Impact Score: {householdImpactScore:F2}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("== Welcome to Emfuleni Municipality Service Desk ==");

            List<Resident> residents = new List<Resident>();
            UtilitiesManager manager = new UtilitiesManager();

            Console.Write("How many residents do you want to register? ");
            int residentCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < residentCount; i++)
            {
                Console.WriteLine($"\n--- Resident {i + 1} ---");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Address: ");
                string address = Console.ReadLine();
                Console.Write("Account Number: ");
                string accountNumber = Console.ReadLine();
                Console.Write("Monthly Utility Usage (kWh or litres): ");
                double usage = double.Parse(Console.ReadLine());

                residents.Add(new Resident(name, address, accountNumber, usage));
            }

            Console.Write("\nHow many service requests do you want to log? ");
            int requestCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < requestCount; i++)
            {
                Console.WriteLine($"\n--- Service Request {i + 1} ---");

                Console.Write($"Select resident by number (1 to {residents.Count}): ");
                int residentIndex = int.Parse(Console.ReadLine()) - 1;

                if (residentIndex < 0 || residentIndex >= residents.Count)
                {
                    Console.WriteLine("Invalid resident selection. Skipping request.");
                    continue;
                }

                Resident selectedResident = residents[residentIndex];

                Console.Write("Request Type (e.g., Water Outage, Burst Pipe): ");
                string requestType = Console.ReadLine();

                Console.Write("Priority Level (1-5): ");
                int priority = int.Parse(Console.ReadLine());

                Console.Write("Severity Level (1-10): ");
                int severity = int.Parse(Console.ReadLine());

                Console.Write("Estimated Resolution Hours: ");
                double estimatedHours = double.Parse(Console.ReadLine());

                ServiceRequest request = new ServiceRequest(selectedResident, requestType, priority, severity, estimatedHours);
                manager.AddServiceRequest(request);
            }

            manager.DisplayPendingQueue();

            var pendingRequests = manager.GetPendingRequests();

            while (pendingRequests.Count > 0)
            {
                Console.WriteLine("\n--- Process Next Request ---");
                manager.DisplayPendingQueue();

                Console.Write("\nSelect request number to process (0 to skip): ");
                int selection = int.Parse(Console.ReadLine());

                if (selection == 0)
                {
                    break;
                }

                ServiceRequest selectedRequest = manager.SelectRequestToProcess(selection - 1);

                if (selectedRequest != null)
                {
                    double adjustedResolution = selectedRequest.EstimatedResolutionHours * (selectedRequest.UrgencyScore / 100);
                    manager.ProcessRequest(selectedRequest, adjustedResolution);
                }
                else
                {
                    Console.WriteLine("Invalid selection.");
                }

                pendingRequests = manager.GetPendingRequests();
            }

            manager.GenerateFinalSummary();

            Console.WriteLine("\nThank you for using the Emfuleni Municipality Service Desk.");
        }
    }
}