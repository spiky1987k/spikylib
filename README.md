# 🦖 spikylib

A tool that allows you to call **C++** function names within **C#** (because **C#** sucks).
## Example Usage
```cs
using spikylib;

namespace CoolProject
{
    internal class Program
    {   
        static void Main(string[] args)
        {
            spikylib.spikylib slib = new spikylib.spikylib();
            slib.printf("hi!");

            string text = slib.getline();
            slib.printf(text);
        }
    }
}

```
## Authors

- [@spiky1987k](https://www.github.com/spiky1987k)
