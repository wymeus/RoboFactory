using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace RoboFactory
{
    public class Robot : IDisposable
    {
        public string Name { get; private set; }
        public Bitmap? Avatar { get; private set; }
        public DateTime GeneratedAt { get; private set; }

        public Robot(string name, Bitmap avatar)
        {
            // Assign
            Name = name;
            Avatar = avatar;
            // Assign creation datetime
            GeneratedAt = DateTime.Now;
        }

        public Robot(string name)
        {
            // Assign
            Name = name;
            // Assign creation datetime
            GeneratedAt = DateTime.Now;
        }

        public void Dispose()
        {
            // Dispose bitmap
            Avatar?.Dispose();
        }

        public static async Task<Robot> GenerateAsync(string defaultRobotName = "null-0000")
        {
            // Get a list of single name
            var result = await DonjonApi.GetRandomNamesAsync(amount: 1);
            // Count check
            if (result.Count > 0)
            {
                // Get the first name
                var name = result.First();
                // Random a 4-digit number
                var identifier = new Random().Next(0, 9999);
                // Get it together
                var robotName = $"{name}-{identifier:D4}";
                // Now generate an avatar
                var avatar = await RoboHashApi.GenerateAsync(robotName);
                // If avatar is not null ...
                if (avatar != null)
                {
                    // Build a new robot and return
                    return new Robot(robotName, avatar);
                }
                else
                {
                    // Otherwise, build a robot with no avatar
                    return new Robot(robotName);
                }
            }
            else
            {
                // Otherwise, return blank robot
                return new Robot(defaultRobotName);
            }
        }
    }
}
