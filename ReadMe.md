# <span style="color:#0ec2b8">_Pierre's Bakery_</span>

#### _ Pierre's Bakery app, 12/11/2020_

#### By _**Nataliya Zhuravleva**_

## <span style="color:#0ec2b8">Description</span>

_This is a console application for bakery that includes the following functionality:_

* _User receive a prompt with a welcome message along with the cost for both Bread and Pastry._

* _User may specify how many loaves of Bread and how many Pastrys they'd like. The application will return the total cost of the order._

* _Pierre offers the following deals:_
    1. _Bread: Buy 2, get 1 free. A single loaf costs $5._
    2. _Pastry: Buy 1 for \$2 or 3 for $5._

## <span style="color:#0ec2b8">Setup/Installation Requirements</span>
### <span style="color:#c4f4ef">Open Online</span>
TODO
### <span style="color:#c4f4ef">Open Locally</span>
1. _Navigate to my [Pierre's Bakery repo](https://github.com/NataliyaZhuravleva/Bakery) at https://github.com/NataliyaZhuravleva/Bakery_ to view the project files and commits.
2. _Click on the green button labeled "Code"_ to copy repository URL.
3. _Clone the repository to your local machine_ by opening your machine terminal and using the command "git clone https://github.com/NataliyaZhuravleva/Bakery".
4. _Navigate to the folder "/Bakery.Tests"/ModelTests/ to see test files._
5. _Navigate to the folder "/Bakery/Models/" to see C# files_
6. _To use this application you will need to install .NET. Please, see instructions below._

### <span style="color:#0ec2b8">.NET Installation</span> 


#### <span style="color:#c4f4ef">Mac</span> 
<p>C# and .NET programming are fully supported on Mac operating systems. We can install .NET and C# on a Mac in a few steps:</p>

1. _Download this [.NET Core SDK (Software Development Kit)](https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.106-macos-x64-installer) . Clicking this link will prompt a .pkg file download from Microsoft._

2. _Open the file. This will launch an installer which will walk you through installation steps. Use the default settings the installer suggests._ 

3. _Confirm the installation is successful by opening your terminal and running the command "$ dotnet --version". You should see something like this in response: 2.2.105. This means both .NET and C# are successfully installed._

#### <span style="color:#c4f4ef">Windows</span> 
Note on Windows Versions
These Windows instructions assume you're using Windows 10. If you currently run Windows 7 or Windows 8, you may have a free upgrade available.

If you are not running Windows 10 (and cannot or do not plan to upgrade), specific installation steps may differ. 

#### Installation Steps:
1. _Download either the the 64-bit .NET Core SDK (Software Development Kit). Clicking these links will prompt a .exe file download from Microsoft._

2. _Open the file and follow the steps provided by the installer for your OS._

3. _Confirm the installation is successful by opening a new Windows PowerShell window and running the command "dotnet --version". You should see something a response like this (version numbers do not need to be the same): 2.2.105_<br>
_This means .NET and C# are installed and our computer recognizes the dotnet command._

### <span style="color:#0ec2b8">Running Program</span> 
#### <span style="color:#c4f4ef">Run Application</span>
<p>You can launch our program with the following steps:</p>

1. _Navigate to the "/Bakery/" folder in the command line._

2. _Run the following command: $ dotnet build_

3. _Run the following command to execute this compiled code: $ dotnet run_


#### <span style="color:#c4f4ef">Run Tests</span> 

 1. _Open Terminal, navigate into the "/Bakery.Tests/" folder in the command line_ 
 2. _Run the command "$ dotnet restore" to retrieve and install the packages_
 3. _Run the following command: $ dotnet test_

## <span style="color:#0ec2b8">Known Bugs</span>

_No known bags_

## <span style="color:#0ec2b8">Support and contact details</span>

_If you have any questions, ideas or concerns, please, contact me at [natalindria@gmail.com](mailto:natalindria@gmail.com)_


## <span style="color:#0ec2b8">Technologies Used</span>

* _C#_
* _.NET_
* _VisualStudio Code_
* _Git_
* _GitHub_
* _MSTest_


## <span style="color:#0ec2b8">Specs</span>

<table>
  <tr>
    <th>ID
    <th>Test</th>
    <th>Input</th>
    <th>Output</th>
    <th>Completed</th>
  </tr>
  <tr>
    <td>1</td>
    <td>Should create Bread objects of the Bread type</td>
    <td>Bread newBread = new Bread();</td>
    <td>typeof(Bread) = newBread.GetType()</td>
    <td>True</td>
  </tr>
  <tr>
    <td>2</td>
    <td>Should correctly return price of Bread</td>
    <td>double price = 4.49;<br>
        Bread newBread = new Bread(price);</td>
    <td>newBread.BreadPrice=4.49</td>
    <td>True</td>
  </tr>
  <tr>
    <td>3</td>
    <td>Should correctly set price of Bread</td>
    <td>double price = 4.49;<br>
        Bread newBread = new Bread(price);<br>
        double updatedPrice=3.49</td>
    <td>newBread.BreadPrice=3.49</td>
    <td>True</td>
  </tr>
  <tr>
    <td>4</td>
    <td>Should create Pastry objects of the Pastry type</td>
    <td>Pastry newPastry = new Pastry();</td>
    <td>typeof(Pastry) = newPastry.GetType()</td>
    <td>True</td>
  </tr>
  <tr>
    <td>5</td>
    <td>Should correctly return price of Pastry</td>
    <td>double price = 2.99;<br>
        Pastry newPastry = new Pastry(price);</td>
    <td>newPastry.PastryPrice=2.99</td>
    <td>True/td>
  </tr>
  <tr>
    <td>6</td>
    <td>Should correctly set price of Pastry</td>
    <td>double price = 2.99;<br>
        Pastry newPastry = new Pastry(price);<br>
        double updatedPrice=1.99</td>
    <td>newPastry.PastryPrice=1.99</td>
    <td>True</td>
  </tr>
  <tr>
    <td>7</td>
    <td>Should correctly return cost of Bread</td>
    <td>int amount=3;<br>
        double price = 4.49;<br>
        Bread newBread = new Bread(price);<br>
    </td>
    <td>newBread.CalculateBreadCost=14.97</td>
    <td>True</td>
  </tr>
  <tr>
    <td>8</td>
    <td>Should correctly return cost of Pastry</td>
    <td>int amount=3;<br>
        double price = 2.99;<br>
        Pastry newPastry = new Pastry(price);<br>
    </td>
    <td>newPastry.CalculatePastryCost=8.97</td>
    <td>True</td>
  </tr>
  <tr>
    <td>9</td>
    <td>Should create Bread objects of the Bread type with _breadDealMarker property</td>
    <td>double price = 4.49;<br>
        Bread newBread = new Bread(price, true);</td>
    <td>typeof(Bread) = newBread.GetType()</td>
    <td>True</td>
  </tr>
  <tr>
    <td>10</td>
    <td>Should create Pastry objects of the Pastry type with _pastryDealMarker property</td>
    <td>double price = 2.99;<br>
        Pastry newPastry = new Pastry(price, true);</td>
    <td>typeof(Bread) = newPastry.GetType()</td>
    <td>False</td>
  </tr>
</table>

### <span style="color:#0ec2b8">License</span> 

*This software is licensed under the [MIT](https://choosealicense.com/licenses/mit/) license*

Copyright (c) 2020 **_Nataliya Zhuravleva_**
