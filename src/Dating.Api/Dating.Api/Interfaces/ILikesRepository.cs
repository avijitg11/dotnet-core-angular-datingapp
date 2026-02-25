using Dating.Api.Entities;
using Dating.Api.Helpers;

namespace Dating.Api.Interfaces
{
    public interface ILikesRepository
    {
        Task<MemberLike?> GetMemberLike(string sourceMemberId, string targetMemberId);
        Task<PaginatedResult<Member>> GetMemberLikes(LikesParams likesParams);
        Task<IReadOnlyList<string>> GetCurrentMemberLikeIds(string memberId);
        void DeleteLike(MemberLike like);
        void AddLike(MemberLike like);
    }
}
