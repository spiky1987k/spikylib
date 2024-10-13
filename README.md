<br>
<br>
<div id="user-content-toc">
    <ul style="list-style: none;">
        <summary>
            <p align="center">
                <img src="https://cdn.discordapp.com/attachments/1294826563828846656/1295017196958781450/Logo800x200.png?ex=670d1e40&is=670bccc0&hm=d287565bcc5844e0ac212ff6750483ed1ecb67c79f8980b9d3e554a7e29ab6e8&" alt="logo" width="600px"/>
            <p/>
        </summary> 
    </ul>
</div>

<div id="user-content-toc" align="center">
    <ul align="center" style="list-style: none;">
        <summary>
            <h1>A tool that allows you to call C++ function names within C#.</h1>
        </summary>
    </ul>
</div>


This is just for University as we're using **C#** but we want to use **C++** (we do not like **C#**). This also features some custom stuff that I've done within my University projects and that I probably will reuse in the future.

<br>

## 🏝️ Get Started 🏝️
Download the latest release and drop the `spikylib.cs` into your project.

<br>

## 🖨️ Example Usage 🖨️
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

<br>

## 🌵 Authors 🌵
- [@spiky1987k](https://www.github.com/spiky1987k)
