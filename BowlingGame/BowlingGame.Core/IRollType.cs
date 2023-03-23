using System.Threading.Tasks.Sources;

namespace BowlingGame.Core;

public interface IRollType
{
   (int score, int index) Roll();
}