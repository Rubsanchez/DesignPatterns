using DesignPatterns.ChainResponsability.Interfaces;

namespace DesignPatterns.ChainResponsability.Models
{
    public class MobileBasicMedium : ISpecification<Mobile>
    {
        public bool IsSatisfied(Mobile item)
        {
            return item.Category == Enums.CategoryType.Medium
                || item.Category == Enums.CategoryType.Basic;
        }
    }
}