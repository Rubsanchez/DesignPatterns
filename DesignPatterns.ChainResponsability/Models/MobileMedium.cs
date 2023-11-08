using DesignPatterns.ChainResponsability.Interfaces;

namespace DesignPatterns.ChainResponsability.Models
{
    public class MobileMedium : ISpecification<Mobile>
    {
        public bool IsSatisfied(Mobile item)
        {
            return item.Category == Enums.CategoryType.Medium;
        }
    }
}