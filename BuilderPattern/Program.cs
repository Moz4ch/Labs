public class CPU
{
    public string Name { get; set; }
    public double Speed { get; set; }
    public int TDP { get; set; }

    public override string ToString()
    {
        return $"{Name}, {Speed} GHz, TDP: {TDP}W";
    }
}

public class Motherboard
{
    public string Model { get; set; }
    public string SocketType { get; set; }
    public string Chipset { get; set; }

    public override string ToString()
    {
        return $"{Model}, Socket: {SocketType}, Chipset: {Chipset}";
    }
}

public class RAM
{
    public string Type { get; set; }
    public int Size { get; set; } // В GB
    public double Speed { get; set; } // В MHz

    public override string ToString()
    {
        return $"{Size} GB {Type}, {Speed} MHz";
    }
}

public class Storage
{
    public string Type { get; set; } // HDD, SSD
    public int Size { get; set; } // В GB
    public int ReadSpeed { get; set; } // В MB/s
    public int WriteSpeed { get; set; } // В MB/s

    public override string ToString()
    {
        return $"{Size} GB {Type}, Read: {ReadSpeed} MB/s, Write: {WriteSpeed} MB/s";
    }
}

public class GPU
{
    public string Brand { get; set; }
    public int Memory { get; set; } // В GB
    public double CoreClock { get; set; } // В MHz
    public string Name { get; set; }

    public override string ToString()
    {
        return $"{Brand} {Name}, {Memory} GB, Core Clock: {CoreClock} MHz";
    }
}

public class Computer
{
    public CPU Processor { get; set; }
    public Motherboard Motherboard { get; set; }
    public RAM Memory { get; set; }
    public Storage Storage { get; set; }
    public GPU GraphicsCard { get; set; }

    public override string ToString()
    {
        return $"Компьютер:\n" +
               $"- Процессор: {Processor}\n" +
               $"- Материнская плата: {Motherboard}\n" +
               $"- Оперативная память: {Memory}\n" +
               $"- Накопитель: {Storage}\n" +
               $"- Видеокарта: {GraphicsCard}";
    }
}
public class ComputerBuilder
{
    private Computer computer;

    public ComputerBuilder()
    {
        computer = new Computer();
    }

    public ComputerBuilder SetCPU(CPU cpu)
    {
        computer.Processor = cpu;
        return this;
    }

    public ComputerBuilder SetMotherboard(Motherboard motherboard)
    {
        computer.Motherboard = motherboard;
        return this;
    }

    public ComputerBuilder SetRAM(RAM ram)
    {
        computer.Memory = ram;
        return this;
    }

    public ComputerBuilder SetStorage(Storage storage)
    {
        computer.Storage = storage;
        return this;
    }

    public ComputerBuilder SetGPU(GPU gpu)
    {
        computer.GraphicsCard = gpu;
        return this;
    }

    public Computer Build()
    {
        return computer;
    }
}

class Program
{
    static void Main(string[] args)
    {
        CPU cpu = new CPU { Name = "Intel core i9-10900", Speed = 2.8, TDP = 65 };
        Motherboard motherboard = new Motherboard { Model = "AsRock", SocketType = "AM4", Chipset = "B450" };
        RAM ram = new RAM { Type = "DDR4", Size = 32, Speed = 3600 };
        Storage storage = new Storage { Type = "SSD", Size = 1024, ReadSpeed = 3500, WriteSpeed = 3000 };
        GPU gpu = new GPU { Brand = "NVIDIA", Name = "RTX 4060TI", Memory = 8, CoreClock = 2310 };

        ComputerBuilder builder = new ComputerBuilder();
        Computer computer = builder
            .SetCPU(cpu)
            .SetMotherboard(motherboard)
            .SetRAM(ram)
            .SetStorage(storage)
            .SetGPU(gpu)
            .Build();

        Console.WriteLine(computer.ToString());
    }
}