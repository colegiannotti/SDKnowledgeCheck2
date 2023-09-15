using KnowledgeCheck2;

Console.WriteLine("How many records do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine());

var recordList = new List<Warrior>();
for (int i = 0; i < numberOfRecords; i++)
{
	string? line;
	int tryResult;
	bool success = false;
	// In this loop, populate the object's properties using Console.ReadLine()
	var myClass = new Warrior();

	Console.WriteLine("\nEnter the value for Name:");
	myClass.Name = Console.ReadLine();

	Console.WriteLine("Enter the value for Strength:");
	do
	{
		line = Console.ReadLine();
		success = int.TryParse(line, out tryResult);
		if (success)
        {
			myClass.Strength = tryResult;
        } else
        {
			Console.WriteLine("Input was not a valid number. Please try again");
		}
	} while (!success);


	recordList.Add(myClass);
}

// Print out the list of records using Console.WriteLine()
foreach (Warrior record in recordList)
{
	Console.WriteLine(record.ToString());
}