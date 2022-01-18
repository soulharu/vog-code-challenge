using Amazon.Lambda.Core;
using Amazon.Lambda.DynamoDBEvents;
using System;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace VogCodeChallenge.AWSLambda
{
    public class Function
    {

        /// <summary>
        /// A simple function that takes a DynamoDBEnvent and log it into console
        /// </summary>
        /// <param name="dynamoDbEvent"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void FunctionHandler(DynamoDBEvent dynamoDbEvent, ILambdaContext context)
        {
            Console.WriteLine($"Processing {dynamoDbEvent.Records.Count} records.");

            Console.WriteLine("\n-----------------------------------");

            foreach (var record in dynamoDbEvent.Records)
            {
                Console.WriteLine($"Event - ID: {record.EventID}, Name: {record.EventName}");

                var pairs = record.Dynamodb.NewImage.Count > 0 ? record.Dynamodb.NewImage : record.Dynamodb.OldImage;

                if (pairs.TryGetValue("Id", out var id))
                    Console.WriteLine($"Entry ID: {id.N}");

                Console.WriteLine("-----------------------------------");
            }

        }
    }
}
