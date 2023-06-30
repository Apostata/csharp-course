

namespace ScreenSound.Models;

internal interface IEvaluable
{
    double Average { get; }
    void AddGrade(Evaluation grade);
}
