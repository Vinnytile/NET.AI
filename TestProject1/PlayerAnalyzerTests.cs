using StudentProject;

namespace StudentTest {
  public class PlayerAnalyzerTests {
    private PlayerAnalyzer _playerAnalyzer;
    private List<Player> _playersList;

    public PlayerAnalyzerTests() {
      _playerAnalyzer = new PlayerAnalyzer();
      _playersList = new List<Player>();
    }

    [Fact]
    public void CalculateScore_GivenSinglePlayer_ReturnsExpectedScore() {
      // Arrange
      var player = new Player {
        Name = "Test Player",
        Age = 25,
        Experience = 5,
        Skills = new List<int> { 2, 2, 2 }
      };
      _playersList.Add(player);

      // Act
      double actualScore = _playerAnalyzer.CalculateScore(_playersList);

      // Assert
      Assert.Equal(250, actualScore);
    }

    [Fact]
    public void CalculateScore_GivenYoungSinglePlayer_ReturnsExpectedScore() {
      // Arrange
      var player = new Player {
        Name = "Test Player",
        Age = 15,
        Experience = 3,
        Skills = new List<int> { 3, 3, 3 }
      };
      _playersList.Add(player);

      // Act
      double actualScore = _playerAnalyzer.CalculateScore(_playersList);

      // Assert
      Assert.Equal(67.5, actualScore);
    }

    [Fact]
    public void CalculateScore_GivenExperiencedPlayer_ReturnsExpectedScore() {
      // Arrange
      var player = new Player {
        Name = "Test Player",
        Age = 35,
        Experience = 15,
        Skills = new List<int> { 4, 4, 4 }
      };
      _playersList.Add(player);

      // Act
      double actualScore = _playerAnalyzer.CalculateScore(_playersList);

      // Assert
      Assert.Equal(2520, actualScore);
    }

    [Fact]
    public void CalculateScore_GivenMultiplePlayers_ReturnsSumOfTheirScores() {
      // Arrange
      var player1 = new Player {
        Name = "Test Player 1",
        Age = 25,
        Experience = 5,
        Skills = new List<int> { 2, 2, 2 } // Score: 250
      };
      var player2 = new Player {
        Name = "Test Player 2",
        Age = 35,
        Experience = 15,
        Skills = new List<int> { 4, 4, 4 } // Score: 2520
      };
      _playersList.Add(player1);
      _playersList.Add(player2);

      // Act
      double actualScore = _playerAnalyzer.CalculateScore(_playersList);

      // Assert
      double expectedScore = 250 + 2520; // Sum of individual scores
      Assert.Equal(expectedScore, actualScore);
    }

    [Fact]
    public void CalculateScore_GivenPlayerWithNullSkills_ThrowsException() {
      // Arrange
      var player = new Player {
        Name = "Test Player",
        Age = 25,
        Experience = 5,
        Skills = null
      };
      _playersList.Add(player);

      // Act & Assert
      Assert.Throws<ArgumentNullException>(() => _playerAnalyzer.CalculateScore(_playersList));
    }

    [Fact]
    public void CalculateScore_GivenEmptyArray_ReturnsZero() {
      // Arrange
     _playersList = new List<Player>();

      // Act
      double actualScore = _playerAnalyzer.CalculateScore(_playersList);

      // Assert
      Assert.Equal(0, actualScore);
    }
  }
}
