Console.WriteLine("What is the passcode for this door (1-10)?");
int input = Convert.ToInt32(Console.ReadLine());
Door thisDoor = CreateDoor(input);

Door CreateDoor(int code)
{
    Door thisDoor = new Door(code, DoorState.Locked);
    return thisDoor;
}

Console.Clear();

ApproachDoor();

void ApproachDoor()
{
    Console.WriteLine("The door is currently " + thisDoor._doorState);
    Console.WriteLine("What would you like to do to the door?");
    Console.WriteLine("1 - Unlock It?");
    Console.WriteLine("2 - Lock It?");
    Console.WriteLine("3 - Open It?");
    Console.WriteLine("4 - Close It?");
    Console.WriteLine("5 - Change Password");
    string input2 = Console.ReadLine();
    if (input2 == "1")
    {
        CheckUnlock();
    } else if (input2 == "2")
    {
        CheckLock();
    } else if (input2 == "3")
    {
        CheckOpen();
    } else if (input2 == "4") 
    {
        CheckClose();
    } else if (input2 == "5")
    {
        ChangePassword();
    }
    else
    {
        ApproachDoor();
    }
}

void CheckUnlock()
{
    if (thisDoor._doorState == DoorState.Locked)
    {
        Console.WriteLine("The door is locked, what is the passcode?");
        int input = Convert.ToInt32(Console.ReadLine());
        if (input == thisDoor._password)
        {
            Console.WriteLine("The door is now unlocked.");
            thisDoor._doorState = DoorState.Unlocked;
            ApproachDoor();
        }
        else
        {
            Console.WriteLine("The password was incorrect!");
            CheckUnlock();
        }
    }
    else
    {
        Console.WriteLine("The door is not locked.");
        ApproachDoor();
    }
}

void CheckLock()
{
    // lock it again
    if (thisDoor._doorState == DoorState.Unlocked)
    {
        Console.WriteLine("The door is unlocked.");
        Console.WriteLine("1 - Open It");
        Console.WriteLine("2 - Lock It");
        string input = Console.ReadLine();
        if (input == "1")
        {
            thisDoor._doorState = DoorState.Opened;
            ApproachDoor();
        } else if (input == "2")
        {
            thisDoor._doorState = DoorState.Locked;
            ApproachDoor();
        }
        else
        {
            ApproachDoor();
        }
    }
    else
    {
        Console.WriteLine("The door isn't unlocked!");
        ApproachDoor();
    }
}

void CheckOpen()
{
    if (thisDoor._doorState == DoorState.Opened)
    {
        Console.WriteLine("The door is openened, would you like to close it?");
        Console.WriteLine("Y - To Close");
        Console.WriteLine("N - To Leave The Door");
        string input = Console.ReadLine();
        if (input == "Y")
        {
            thisDoor._doorState = DoorState.Closed;
            ApproachDoor();
        } 
        else
        {
            ApproachDoor();
        }
    }
    else
    {
        Console.WriteLine("The door isn't opened!");
        ApproachDoor();
    }
}

void CheckClose()
{
    if (thisDoor._doorState == DoorState.Closed)
    {
        Console.WriteLine("The door is closed, will you lock it?");
        Console.WriteLine("Y - Lock the door.");
        Console.WriteLine("N - Leave the door.");
        string input = Console.ReadLine();
        if (input == "Y")
        {
            thisDoor._doorState = DoorState.Locked;
            ApproachDoor();
        }
        else
        {
            ApproachDoor();
        }
    }
    else
    {
        Console.WriteLine("The door is not closed!");
        ApproachDoor();
    }
}

void ChangePassword()
{
    Console.WriteLine("What is the current password?");
    int input = Convert.ToInt32(Console.ReadLine());
    if (input == thisDoor._password)
    {
        Console.WriteLine("What is the new password?");
        int newpass = Convert.ToInt32(Console.ReadLine());
        thisDoor._password = newpass;
        ApproachDoor();
    }
    else
    {
        Console.WriteLine("Invalid Password!");
        ApproachDoor();
    }
}
class Door
{
    public int _password;
    public DoorState _doorState;

    public Door(int password, DoorState doorState)
    {
        _password = password;
        _doorState = doorState;
    }
}
enum DoorState
{
    Opened,
    Closed,
    Locked,
    Unlocked
}