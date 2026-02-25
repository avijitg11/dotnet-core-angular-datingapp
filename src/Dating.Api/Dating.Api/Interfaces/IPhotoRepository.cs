using Dating.Api.DTOs;
using Dating.Api.Entities;

namespace Dating.Api.Interfaces
{
    public interface IPhotoRepository
    {
        Task<IReadOnlyList<PhotoForApprovalDto>> GetUnapprovedPhotos();
        Task<Photo?> GetPhotoById(int id);
        void RemovePhoto(Photo photo);
    }
}
