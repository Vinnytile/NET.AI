using StudentProject;

namespace StudentTest {
  public class StudentConverterTests {
    private StudentConverter _studentConverter;
    private List<Student> _studentsList;

    public StudentConverterTests() {
      _studentConverter = new StudentConverter();
      _studentsList = new List<Student>();
    }

    [Fact]
    public void ConvertStudents_ShouldSetHonorRollForStudentsOver21WithGradeOver90() {
      // Arrange
      var student = new Student {
        Name = "John",
        Age = 21,
        Grade = 91
      };
      _studentsList.Add(student);

      // Act
      var convertedStudents = _studentConverter.ConvertStudents(_studentsList);

      // Assert
      Assert.True(convertedStudents[0].HonorRoll);
    }

    [Fact]
    public void ConvertStudents_ShouldSetExceptionalForStudentsUnder21WithGradeOver90() {
      // Arrange
      var student = new Student {
        Name = "John",
        Age = 20,
        Grade = 91
      };
      _studentsList.Add(student);

      // Act
      var convertedStudents = _studentConverter.ConvertStudents(_studentsList);

      // Assert
      Assert.True(convertedStudents[0].Exceptional);
    }

    [Fact]
    public void ConvertStudents_ShouldSetPassedForStudentsWithGradeBetween71And90() {
      // Arrange
      var student = new Student {
        Name = "John",
        Age = 20,
        Grade = 80
      };
      _studentsList.Add(student);

      // Act
      var convertedStudents = _studentConverter.ConvertStudents(_studentsList);

      // Assert
      Assert.True(convertedStudents[0].Passed);
    }

    [Fact]
    public void ConvertStudents_ShouldSetPassedToFalseForStudentsWithGrade70OrLess() {
      // Arrange
      var student = new Student {
        Name = "John",
        Age = 20,
        Grade = 70
      };
      _studentsList.Add(student);

      // Act
      var convertedStudents = _studentConverter.ConvertStudents(_studentsList);

      // Assert
      Assert.False(convertedStudents[0].Passed);
    }

    [Fact]
    public void ConvertStudents_ShouldReturnEmptyListWhenGivenEmptyList() {
      // Arrange
      _studentsList = new List<Student>();

      // Act
      var convertedStudents = _studentConverter.ConvertStudents(_studentsList);

      // Assert
      Assert.Empty(convertedStudents);
    }

    [Fact]
    public void ConvertStudents_ShouldThrowArgumentNullExceptionWhenGivenNull() {
      // Arrange
      _studentsList = null;

      // Act and Assert
      Assert.Throws<ArgumentNullException>(() => _studentConverter.ConvertStudents(_studentsList));
    }
  }
}