using DesignPatterns.ChainResponsability.Interfaces;

namespace DesignPatterns.ChainResponsability.Models
{
    public class MobilePremium : ISpecification<Mobile>
    {
        public bool IsSatisfied(Mobile item)
        {
            return item.Category == Enums.CategoryType.Premium;
        }
    }
}