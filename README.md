# How to host WPF Chart control in Windows Forms project
This article offers a step-by-step guide to integrating a WPF Chart control into a Windows Forms project. Hosting a WPF Chart control within a Windows Forms application enables access to the advanced and modern features of WPF while maintaining the existing Windows Forms infrastructure. Follow these steps:

### Step 1: Create a Windows Forms Project

   1. Open Visual Studio.
   2. Create a new Windows Forms App project.
   3. Name your project and select the appropriate .NET version.
   4. Click Create
      
 ![This image demonstrates how to create a new Windows Forms App project.](https://support.syncfusion.com/kb/agent/attachment/article/18893/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjM1MjAwIiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.A5dQXEVlZvVH69XldMbdO4L0mbTN3m_DmIyq-o9rfbE)
 
### Step 2: Create a Windows Control Library

To encapsulate and reuse the WPF chart control, need to create a Windows Control Library:

   1. Right-click the solution in Solution Explorer and select Add then select New Project.
   2.  Search for Windows Forms Control Library and select the project
   3. Name the project and select the appropriate framework.
   4. Click Create.
  
 ![This image demonstrates how to create a new Windows Control Library Project](https://support.syncfusion.com/kb/agent/attachment/article/18893/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjM1MjA0Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.drvonvGOiOSYAK4ALZICiP0TU82IeOZU2rlW6XcgE0k) 


### Step 3: Configure the required WPF assemblies

To enable the use of WPF Chart controls within the project, it is necessary to add the required WPF assemblies. Follow these steps:

1. Right-click the Windows Control Library project and select Manage NuGet Packages.
2. Install the [Syncfusion.SfChart.WPF](https://www.syncfusion.com/wpf-controls/charts){target="_blank"} packages.

### Step 4: Add a WPF User Control to the project

To host the WPF Chart control, a WPF User Control must be added to the Windows Control Library project. Follow these steps:

   1. Right-click the Windows Control Library project.
   2. Select Add then select New Item.
   3. Choose WPF User Control and name it.
 
 ![This image demonstrates how to create a WPF user control.](https://support.syncfusion.com/kb/agent/attachment/article/18893/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjM1MjA2Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.wD73rn09JIl7lCmfcIDBFEf1-IkbC_7ZVzns1e57ZSU)

### Step 5: Configure the Syncfusion WPF Chart in the UserControl.Xaml File

Then it is needed to add the necessary configuration for Syncfusion WPF Chart in the loaded SfChartControl.Xaml (UserControl.Xaml file). Refer the following code snippets.

 ```xml
<chart:SfChart x:Name="SplineAreaChart" Margin="5" HorizontalAlignment="Center">

    <chart:SfChart.DataContext>
        <model:SplineAreaChartViewModel/>
    </chart:SfChart.DataContext>
    
    <chart:SfChart.PrimaryAxis>
        <chart:CategoryAxis Interval="2" EdgeLabelsDrawingMode="Shift" ShowGridLines="false" PlotOffset="10">
        </chart:CategoryAxis>
    </chart:SfChart.PrimaryAxis>

    <chart:SfChart.SecondaryAxis>
        <chart:NumericalAxis  Maximum="12" Minimum="0" Interval="2" ShowGridLines="True"  LabelFormat="0'%">
        </chart:NumericalAxis>
    </chart:SfChart.SecondaryAxis>

    <chart:SplineAreaSeries Interior="#00AEE0"
                            ItemsSource="{Binding SplineAreaData}"
                            Label="India"
                            XBindingPath="Year"
                            YBindingPath="India" />

    <chart:SplineAreaSeries Interior="#96D759"
                            ItemsSource="{Binding SplineAreaData}"
                            Label="China"
                            XBindingPath="Year"
                            YBindingPath="China" />
</chart:SfChart>
 ```
 
### Step 6: Need to create Element Host class

To load a WPF control in a Windows Forms application, create a class in the Windows Forms application that derives from ElementHost and load the SfChartControl WPF control into it. Refer to the following code snippet.
 
 ```csharp
using System.ComponentModel.Design.Serialization;
using System.ComponentModel;
using WindowsFormsControlLibrary;

namespace SimpleSample
{
    [Designer("System.Windows.Forms.Design.ControlDesigner, System.Design")]
    [DesignerSerializer("System.ComponentModel.Design.Serialization.TypeCodeDomSerializer , System.Design", "System.ComponentModel.Design.Serialization.CodeDomSerializer, System.Design")]
    public class ChartHost : System.Windows.Forms.Integration.ElementHost
    {
        protected SfChartControl m_WPFSfChart = new();
        public ChartHost()
        {
            base.Child = m_WPFSfChart;
        }
    }
} 
 ```
 
### Step 7: Add Code to the Windows Forms Project File to Use the WPF Control

Need to add the following code snippet in Winforms project file to use WPF Control in winforms application
 
 ```xml
<UseWPF>true</UseWPF> 
 ```
 
### Step 8: Need to attach Windows Control Library project into Windows Forms application.

It is needed to attach the created Windows Control Library project into Windows Forms application and add it to its assembly reference section.

### Step 9: Need to add SfChartcontrol in Windows Forms application

As both the applications are merged, it is needed to rebuild the whole application. It will add SfChartControl WPF control in Windows Forms Application Designer Page Toolbox. It can be dragged and dropped into the Form Designer.
 
  
 ![This image demonstrates designer page toolbox](https://support.syncfusion.com/kb/agent/attachment/article/18893/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjM1MzAyIiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.vX_arH2klFUH-zZptrfQjtgZOpwmDqkBlsI08h0VYSI)

### Output:

 
 ![This image demonstrates output to host wpf chart in winforms](https://support.syncfusion.com/kb/agent/attachment/article/18893/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjM1MzAzIiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.DoIMMJd2NJMZpxJpi1MwMYBhVfG8i1swTcQqsRi60bA)

### Troubleshooting:

**Path too long exception**

If you are facing a path too long exception when building this example project, close Visual Studio and rename the repository to a shorter name before building the project.

For more details, refer to the KB on How to host WPF Chart control in Windows Forms project ?