using System;

namespace CazamioNewProject.DbHelpers.MarketplaceAdminsTable
{
    public class MarketplaceAdminsDbModels
    {
        public object? Id { get; set; } // this might be another data type
        public object? UserId { get; set; }
        public object? CreationDate { get; set; }
        public object? ModifyDate { get; set; }
        public object? IsDeleted { get; set; }
        public object? MarketplaceId { get; set; }
    }
}
