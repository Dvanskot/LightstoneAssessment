using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightstoneAssessmentTests;

public class StringManagementTests 
{
    Inputs _inputs;
    StringManager _stringManager;

    public StringManagementTests()
    {
        
        _inputs = new Inputs
        {
            NumberOfCases = 1,
            InputString = "this is a test",
        };

        _stringManager = new StringManager();
    }

   

    [Fact]
    public void NumberOfCases_Validation_Test()
    {

        //Arrange
        bool expected = true;

        //Act
        bool actual = _inputs.ValidateNumberOfCases;

        //Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void InputString_Validation_Spaces_Should_Not_Appear_At_The_Start_Or_End_of_a_Line_Test()
    {
        //Arrange
        bool expected = true;

        //Act
        bool actual = _inputs.ValidateInputString;

        //Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void StringManager_TransformWords_Test()
    {
        //Arrange
        string expected = "test a is this";

        //Act
        string actual = _stringManager.TransformWords(_inputs.InputString);

        //Assert
        Assert.Equal(expected, actual);
    }
}
