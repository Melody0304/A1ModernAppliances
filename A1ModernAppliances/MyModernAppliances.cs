using ModernAppliances.Entities;
using ModernAppliances.Entities.Abstract;
using ModernAppliances.Helpers;
using System;
using System.Collections.Generic;

namespace ModernAppliances
{
    /// <summary>
    /// Manager class for Modern Appliances
    /// </summary>
    /// <remarks>Author: </remarks>
    /// <remarks>Date: </remarks>
    internal class MyModernAppliances : ModernAppliances
    {
        /// <summary>
        /// Option 1: Performs a checkout
        /// </summary>
        public override void Checkout()
        {
            // Write "Enter the item number of an appliance: "
            Console.WriteLine("Enter the item number of an appliance:");

            // Create long variable to hold item number
            long itemNumber;
          
            // Get user input as string and assign to variable.
            string userInput = Console.ReadLine();

            // Convert user input from string to long and store as item number variable.
            long userInputLong = long.Parse(userInput);
            itemNumber = userInputLong;

            // Create 'foundAppliance' variable to hold appliance with item number
            Appliance? foundAppliance;

            // Assign null to foundAppliance (foundAppliance may need to be set as nullable)
            foundAppliance = null;

            // Loop through Appliances
            foreach (var appliance in Appliances) 
            {
                // Test appliance item number equals entered item number
                if (appliance.ItemNumber == itemNumber)
                {
                    // Assign appliance in list to foundAppliance variable
                    foundAppliance= appliance;
                    // Break out of loop (since we found what need to)
                    break;
                }
            }

            // Test appliance was not found (foundAppliance is null)
            if (foundAppliance == null)
            {
                // Write "No appliances found with that item number."
                Console.WriteLine("No appliances found with that item number.");
            }
            // Otherwise (appliance was found)
            else
            {
                // Test found appliance is available
                if (foundAppliance != null)
                {
                    // Checkout found appliance
                    // Write "Appliance has been checked out."
                    foundAppliance.Checkout();
                    Console.WriteLine("Appliance has been checked out.");
                }
                // Otherwise (appliance isn't available)
                else
                {
                    // Write "The appliance is not available to be checked out."
                    Console.WriteLine("The appliance is not available to be checked out");
                }

            }
        }

        /// <summary>
        /// Option 2: Finds appliances
        /// </summary>
        public override void Find()
        {
            // Write "Enter brand to search for:"
            Console.WriteLine("Enter brand to search for:");

            // Create string variable to hold entered brand
            string enterBrand;

            // Get user input as string and assign to variable.
            string userInput2 = Console.ReadLine();

            // Create list to hold found Appliance objects
            List<Appliance> appliances = new List<Appliance>();

            // Iterate through loaded appliances
            foreach (var appliance in Appliances)
            {
                // Test current appliance brand matches what user entered
                if (appliance.Brand == userInput2)
                {
                    // Add current appliance in list to found list
                    appliances.Add(appliance);
                }
            }

            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
            DisplayAppliancesFromList(appliances, 0);
        }

        /// <summary>
        /// Displays Refridgerators
        /// </summary>
        public override void DisplayRefrigerators()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options:");

            // Write "0 - Any"
            Console.WriteLine("0 - Any");
            // Write "2 - Double doors"
            Console.WriteLine("2 - Double doors");
            // Write "3 - Three doors"
            Console.WriteLine("3 - Three doors");
            // Write "4 - Four doors"
            Console.WriteLine("4 - Four doors");

            // Write "Enter number of doors: "
            Console.WriteLine("Enter number of doors: ");

            // Create variable to hold entered number of doors
            long doorsNumber;

            // Get user input as string and assign to variable
            string userInput3 = Console.ReadLine();

            // Convert user input from string to int and store as number of doors variable.
            int userInputLong = int.Parse(userInput3);
            doorsNumber = userInputLong;

            // Create list to hold found Appliance objects
            List<Appliance> appliances = new List<Appliance>();

            // Iterate/loop through Appliances
            foreach(var appliance in Appliances)
            {
                // Test that current appliance is a refrigerator
                if (appliance is Refrigerator)
                {
                    // Down cast Appliance to Refrigerator
                    // Refrigerator refrigerator = (Refrigerator) appliance;
                    Refrigerator refrigerator = (Refrigerator)appliance;

                    // Test user entered 0 or refrigerator doors equals what user entered.
                    if (userInput3 == "0" | doorsNumber == refrigerator.Doors)
                    {
                        // Add current appliance in list to found list
                        appliances.Add(appliance);
                    }
                }
            }
            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
            DisplayAppliancesFromList(appliances, 0);
        }

        /// <summary>
        /// Displays Vacuums
        /// </summary>
        /// <param name="grade">Grade of vacuum to find (or null for any grade)</param>
        /// <param name="voltage">Vacuum voltage (or 0 for any voltage)</param>
        public override void DisplayVacuums()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options:");
            // Write "0 - Any"
            Console.WriteLine("0 - Any");
            // Write "1 - Residential"
            Console.WriteLine("1 - Residential");
            // Write "2 - Commercial"
            Console.WriteLine("2 - Commercial");
            // Write "Enter grade:"
            Console.WriteLine("Enter grade:");

            // Get user input as string and assign to variable
            string userInput4 = Console.ReadLine();

            // Create grade variable to hold grade to find (Any, Residential, or Commercial)
            string grade;

            // Test input is "0"
            if (userInput4 == "0")
            {
                // Assign "Any" to grade
                grade = "Any";
            }
            // Test input is "1"
            else if (userInput4 == "1") 
            {
                // Assign "Residential" to grade
                grade = "Residential";
            }
            else if (userInput4 == "2") 
            {
                // Assign "Commercial" to grade
                grade = "Commercial";
            }
            // Otherwise (input is something else)
            else
            {
                // Write "Invalid option."
                Console.WriteLine("Invalid option.");
                // Return to calling (previous) method
                // return;
                return;
            }

               

            // Write "Possible options:"
            Console.WriteLine("Possible options:");
            // Write "0 - Any"
            Console.WriteLine("0 - Any");
            // Write "1 - 18 Volt"
            Console.WriteLine("1 - 18 Volt");
            // Write "2 - 24 Volt"
            Console.WriteLine("2 - 24 Volt");
            // Write "Enter voltage:"
            Console.WriteLine("Enter voltage:");

            // Get user input as string
            string userInput5 = Console.ReadLine();

            // Create variable to hold voltage
            short voltage;

            // Test input is "0"
            if (userInput5 == "0")
            {
                // Assign 0 to voltage
                voltage = 0;
            }
            // Test input is "1"
            else if(userInput5 == "1")
            {
                // Assign 18 to voltage
                voltage = 18;
            }
            // Test input is "2"
            else if (userInput5 == "2")
            {
                // Assign 24 to voltage
                voltage = 24;
            }
            // Otherwise
            else
            {
                // Write "Invalid option."
                Console.WriteLine("Invalid option.");
                // Return to calling (previous) method
                // return;
                return;
            }

            // Create found variable to hold list of found appliances.
           List<Appliance> list = new List<Appliance>();

            // Loop through Appliances
            foreach (var appliance in list)
            {
                // Check if current appliance is vacuum
                if (appliance is Vacuum)
                {
                    // Down cast current Appliance to Vacuum object
                    // Vacuum vacuum = (Vacuum)appliance;
                    Vacuum vacuum = (Vacuum)appliance;

                    // Test grade is "Any" or grade is equal to current vacuum grade and voltage is 0 or voltage is equal to current vacuum voltage
                    if ((grade == "Any" || vacuum.Grade == grade) && (voltage == 0 || vacuum.BatteryVoltage == voltage))
                    {
                        // Add current appliance in list to found list
                        list.Add(vacuum);
                    }
                }

            }

            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
            DisplayAppliancesFromList(list, 0);
        }

        /// <summary>
        /// Displays microwaves
        /// </summary>
        public override void DisplayMicrowaves()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options:");
            // Write "0 - Any"
            Console.WriteLine("0 - Any");
            // Write "1 - Kitchen"
            Console.WriteLine("1 - Kitchen");
            // Write "2 - Work site"
            Console.WriteLine("2 - Work site");
            // Write "Enter room type:"
            Console.WriteLine("Enter room type:");
            // Get user input as string and assign to variable
            string userInput6 = Console.ReadLine();

            // Create character variable that holds room type
            char? roomType = null;

            // Test input is "0"
            if (userInput6 == "0") 
            {
                // Assign 'A' to room type variable
                roomType= 'A';
            }
 
            // Test input is "1"
            else if (userInput6 == "1") 
            {
                // Assign 'K' to room type variable
                roomType= 'K';
            }
            
            // Test input is "2"
            else if(userInput6 == "2")
            {
                // Assign 'W' to room type variable
                roomType= 'W';
            }

            // Otherwise (input is something else)
            else
            {
                // Write "Invalid option."
                Console.WriteLine("Invalid option.");
                // Return to calling method
                // return;
                return;

            }

            

            // Create variable that holds list of 'found' appliances
            List<Appliance> list = new List<Appliance>();

            // Loop through Appliances
            foreach (var appliance in list)
            {
                // Test current appliance is Microwave
                if (appliance is Microwave)
                {
                    // Down cast Appliance to Microwave
                    Microwave microwave = (Microwave)appliance;
                    // Test room type equals 'A' or microwave room type
                    if (roomType == 'A' | roomType == microwave.RoomType)
                    {
                        // Add current appliance in list to found list
                        list.Add(appliance);
                    }
                }
            }

            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
            DisplayAppliancesFromList(list, 0);
        }

        /// <summary>
        /// Displays dishwashers
        /// </summary>
        public override void DisplayDishwashers()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options:");
            // Write "0 - Any"
            Console.WriteLine("0 - Any");
            // Write "1 - Quietest"
            Console.WriteLine("1 - Quietest");
            // Write "2 - Quieter"
            Console.WriteLine("2 - Quieter");
            // Write "3 - Quiet"
            Console.WriteLine("3 - Quiet");
            // Write "4 - Moderate"
            Console.WriteLine("4 - Moderate");
            // Write "Enter sound rating:"
            Console.WriteLine("Enter sound rating:");

            // Get user input as string and assign to variable
            string userInput7 = Console.ReadLine();

            // Create variable that holds sound rating
            string soundRating;

            // Test input is "0"
            if (userInput7 == "0")
            {
                // Assign "Any" to sound rating variable
                soundRating = "Any";
            }

            // Test input is "1"
            else if (userInput7 == "1")
            {
                // Assign "Qt" to sound rating variable
                soundRating = "Qt";
            }

            // Test input is "2"
            else if (userInput7 == "2")
            {
                // Assign "Qr" to sound rating variable
                soundRating = "Qr";
            }

            // Test input is "3"
            else if (userInput7 == "3")
            {
                // Assign "Qu" to sound rating variable
                soundRating = "Qu";
            }

            // Test input is "4"
            else if (userInput7 == "4")
            {
                // Assign "M" to sound rating variable
                soundRating = "M";
            }

            // Otherwise (input is something else)
            else
            {
                // Write "Invalid option."
                Console.WriteLine(" Invalid option.");
                // Return to calling method
                return;
            }

            

            // Create variable that holds list of found appliances
            List<Appliance> list = new List<Appliance>();

            // Loop through Appliances
            foreach (Appliance appliance in list)
            {
                // Test if current appliance is dishwasher
                if (appliance is Dishwasher)
                {
                    // Down cast current Appliance to Dishwasher
                    Dishwasher dishwasher = (Dishwasher)appliance;

                    // Test sound rating is "Any" or equals soundrating for current dishwasher
                    if (soundRating =="Any" | soundRating == dishwasher.SoundRating)
                    {
                        // Add current appliance in list to found list
                        list.Add(dishwasher);
                    }
                }
            }

            // Display found appliances (up to max. number inputted)
            // DisplayAppliancesFromList(found, 0);
            DisplayAppliancesFromList(list, 0);
        }

        /// <summary>
        /// Generates random list of appliances
        /// </summary>
        public override void RandomList()
        {
            // Write "Appliance Types"
            Console.WriteLine("Appliance Types");
            // Write "0 - Any"
            Console.WriteLine("0 - Any");
            // Write "1 – Refrigerators"
            Console.WriteLine("1 – Refrigerators");
            // Write "2 – Vacuums"
            Console.WriteLine("2 – Vacuums");
            // Write "3 – Microwaves"
            Console.WriteLine("3 – Microwaves");
            // Write "4 – Dishwashers"
            Console.WriteLine("4 – Dishwashers");

            // Write "Enter type of appliance:"
            Console.WriteLine("Enter type of appliance:");

            // Get user input as string and assign to appliance type variable
            string userInput8 = Console.ReadLine();

            // Write "Enter number of appliances: "
            Console.WriteLine("Enter type of appliance:");

            // Get user input as string and assign to variable
            string userInput9 = Console.ReadLine();

            // Convert user input from string to int
            int userInputLong = int.Parse(userInput9);

            // Create variable to hold list of found appliances
            List<Appliance> list = new List<Appliance>();

            // Loop through appliances
            foreach (Appliance appliance in list)
            {
                // Test inputted appliance type is "0"
                if (userInput8 == "0")
                {
                    // Add current appliance in list to found list
                    list.Add(appliance);
                }
                // Test inputted appliance type is "1"
                else if(userInput8 == "1")
                {
                    // Test current appliance type is Refrigerator
                    if (userInput9 == "Refrigerator")
                    {
                        // Add current appliance in list to found list
                        list.Add(appliance);
                    }
                }
                // Test inputted appliance type is "2"
                else if (userInput8 == "2")
                {
                    // Test current appliance type is Vacuum
                    if (userInput9 == "Vacuum")
                    {
                        // Add current appliance in list to found list
                        list.Add(appliance);
                    }
                }
                // Test inputted appliance type is "3"
                else if (userInput8 == "3")
                {
                    // Test current appliance type is Microwave
                    if (userInput9 == "Microwave")
                    {
                        // Add current appliance in list to found list
                        list.Add(appliance);
                    }
                }
                // Test inputted appliance type is "4"
                else if (userInput8 == "4")
                {
                    // Test current appliance type is Dishwasher
                    if (userInput9 == "Dishwasher")
                    {
                        // Add current appliance in list to found list
                        list.Add(appliance);
                    }
                }
            }

            // Randomize list of found appliances
            // found.Sort(new RandomComparer());
            list.Sort(new RandomComparer());


            // Display found appliances (up to max. number inputted)
            // DisplayAppliancesFromList(found, num);
            DisplayAppliancesFromList(list, userInputLong);
        }
    }
    }
