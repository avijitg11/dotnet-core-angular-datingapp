using Dating.Api.Entities;
using Dating.Api.Helpers;

namespace Dating.Api.Interfaces
{
    public interface IMemberRepository
    {
        void Update(Member member);
        Task<PaginatedResult<Member>> GetMembersAsync(MemberParams memberParams);
        Task<Member?> GetMemberByIdAsync(string id);
        Task<IReadOnlyList<Photo>> GetPhotosForMemberAsync(string memberId, bool isCurrentUser);
        Task<Member?> GetMemberForUpdate(string id);
    }
}
