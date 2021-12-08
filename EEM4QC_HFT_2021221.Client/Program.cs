using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using EEM4QC_HFT_2021221.Models;

namespace EEM4QC_HFT_2021221.Client
{
    public class HrEmployee
    {

        public int Emp_Id { get; set; }
        public string Emp_Name { get; set; }
        public string Emp_Surname { get; set; }
        public bool Emp_Is_Existed { get; set; }
    }

    class Program
    {
        static HttpClient client = new HttpClient();

        static void ShowHrEmployee(HrEmployee employee)
        {
            if (employee is null)
            {
                throw new ArgumentNullException(nameof(employee));
            }
            Console.WriteLine($"Emp_Name: {employee.Emp_Name}\tEmp_Surname: " +
                $"{employee.Emp_Surname}\tEmp_Is_Existed: {employee.Emp_Is_Existed}");
        }

        static async Task<Uri> CreateHrEmployeeAsync(HrEmployee employee)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(
                "Employee/Create", employee);
            response.EnsureSuccessStatusCode();
            // return URI of the created resource.
            return response.Headers.Location;
        }

        static async Task<HrEmployee> GetHrEmployeeAsync(string path)
        {
            HrEmployee employee = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                employee = await response.Content.ReadAsAsync<HrEmployee>();
            }
            return employee;
        }

        static async Task<HrEmployee> UpdateHrEmployeeAsync(HrEmployee employee)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync(
                $"Employee/Update/{employee.Emp_Id}", employee);
            response.EnsureSuccessStatusCode();

            // Deserialize the updated employee from the response body.

            employee = await response.Content.ReadAsAsync<HrEmployee>();
            return employee;
        }

        static async Task<HttpStatusCode> DeleteHrEmployeeAsync(int employee_id)
        {
            HttpResponseMessage response = await client.DeleteAsync(
                $"Employee/Delete/{employee_id}");
            return response.StatusCode;
        }

        static void Main()
        {
            RunAsync().GetAwaiter().GetResult();
        }

        static async Task RunAsync()
        {

           

            client.BaseAddress = new Uri("http://localhost:25793/api/EEM4QC_HFT_2021221.Endpoint/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                // Create a new employee
                HrEmployee employee = new HrEmployee
                {
                    Emp_Name = "Aynur",
                    Emp_Surname = "Abdul",
                    Emp_Is_Existed = true
                };

                var url = await CreateHrEmployeeAsync(employee);
                Console.WriteLine($"Created at {url}");

                // Get the employee
                employee = await GetHrEmployeeAsync(url?.PathAndQuery);
                if (employee is null)
                {
                    throw new ArgumentNullException(nameof(employee));
                }
                ShowHrEmployee(employee);

                // Update the employee

                Console.WriteLine("Updating Surname");
                employee.Emp_Surname = "Abdul";

                await UpdateHrEmployeeAsync(employee);

                // Get the updated employee

                employee = await GetHrEmployeeAsync(url.PathAndQuery);
                ShowHrEmployee(employee);

                // Delete the employee

                var statusCode = await DeleteHrEmployeeAsync(employee.Emp_Id);
                Console.WriteLine($"Deleted (HTTP Status = {(int)statusCode})");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}