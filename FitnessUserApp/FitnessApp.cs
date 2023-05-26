using EasyNetQ;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace FitnessUserApp
{
    public partial class FitnessApp : Form
    {
        HttpClient client = new HttpClient();
        string apiUrl = "https://localhost:7184/User";

        private IBus bus;
        private const string exchangeName = "fitnessApp_exchange";
        private const string queueName = "fitnessApp_queue";
        private const string routingKey = "fitnessApp_routing_key";

        public FitnessApp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Connect to the RabbitMQ server
            bus = RabbitHutch.CreateBus("amqps://cmcbjlme:aF-QmhuXS-dFiVX8SMUDzYLk0v9dGO8i@hawk.rmq.cloudamqp.com/cmcbjlme");

            // Declare an exchange
            var exName = bus.Advanced.ExchangeDeclare(exchangeName, "fanout");

            // Declare a queue
            var qName = bus.Advanced.QueueDeclare(queueName);

            // Bind the queue to the exchange
            bus.Advanced.Bind(exName, qName, routingKey);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Close the bus connection when the form is closing
            bus?.Dispose();
        }

        private async void sendRequestHTTP_Click(object sender, EventArgs e)
        {
            string _firstName = fNameField.Text;
            string _lastName = lNameField.Text;
            int _age = int.Parse(ageField.Text);
            string _sex = shreksField.Text;
            double _weight = double.Parse(weightField.Text);
            double _desiredWeight = double.Parse(desWeightField.Text);
            double _height = double.Parse(HeightField.Text);
            double _lossPrWeek = double.Parse(wLossPerWeekField.Text);

            var data = new
            {
                FirstName = _firstName,
                LastName = _lastName,
                Age = _age,
                Sex = _sex,
                Weight = _weight,
                DesiredWeight = _desiredWeight,
                Height = _height,
                WeightLossPerWeek = _lossPrWeek
            };

            //Serialize the object to JSON format using Newtonsoft.Json
            string jsonBody = JsonConvert.SerializeObject(data);

            //Create a new instance of the StringContent class with the JSON body and
            //specify the content type as "application/json"
            var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");
            try
            {
                //Use the HttpClient instance to call the API endpoint within your solution
                //by specifying the appropriate HTTP method (e.g., POST, PUT, GET, etc.) and passing the content
                HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    // The request was successful, handle the response
                    string responseBody = await response.Content.ReadAsStringAsync();
                    // Parse the response body if necessary

                    HttpStatusCode statusCode = response.StatusCode;
                    succesLabelHTTP.Text = statusCode.ToString();
                }
                else
                {
                    // The request failed, handle the error
                    string responseBody = await response.Content.ReadAsStringAsync();
                    // You can access the status code, reason phrase, and response body from the response object
                    HttpStatusCode statusCode = response.StatusCode;
                    string reasonPhrase = response.ReasonPhrase;

                    succesLabelHTTP.Text = "!Some Error Happened!";

                    // Handle the error based on the status code or response content
                    // For example, you can throw a custom exception or display an error message to the user
                    throw new Exception($"API request failed with status code: {statusCode}, reason: {reasonPhrase}, response: {responseBody}");
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occurred during the API call
                // You can log the exception or display an error message to the user
                Console.WriteLine($"An error occurred while calling the API: {ex.Message}");
            }
        }

        private void sendRequestMessage_Click(object sender, EventArgs e)
        {
            string _firstName = fNameField.Text;
            string _lastName = lNameField.Text;
            int _age = int.Parse(ageField.Text);
            string _sex = shreksField.Text;
            double _weight = double.Parse(weightField.Text);
            double _desiredWeight = double.Parse(desWeightField.Text);
            double _height = double.Parse(HeightField.Text);
            double _lossPrWeek = double.Parse(wLossPerWeekField.Text);

            var data = new
            {
                FirstName = _firstName,
                LastName = _lastName,
                Age = _age,
                Sex = _sex,
                Weight = _weight,
                DesiredWeight = _desiredWeight,
                Height = _height,
                WeightLossPerWeek = _lossPrWeek
            };

            // Serialize the object to JSON format
            string jsonBody = JsonConvert.SerializeObject(data);

            // Publish the message to the exchange with the specified routing key
            bus.PubSub.Publish(jsonBody, exchangeName);

            successLabelMessage.Text = "Message published successfully!";
        }
    }
}
