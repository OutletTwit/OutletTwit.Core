using System;
using System.Drawing;

namespace OutletTwit.Core.Api.Models
{
    public interface IUser : IProbableSnowflakeObject
    {
        string Name { get; }
        string ScreenName { get; }
        string Location { get; }
        string Description { get; }
        Uri Url { get; }
        bool Protected { get; }
        long FollowersCount { get; }
        long FriendsCount { get; }
        long ListedCount { get; }
        long FavouritesCount { get; }
        TimeSpan UtcOffset { get; }
        string TimeZone { get; }
        bool GeoEnabled { get; }
        bool Verified { get; }
        long StatusesCount { get; }
        string Lang { get; }
        bool ContributorsEnabled { get; }
        bool IsTranslator { get; }
        bool IsTranslationEnabled { get; }
        Color ProfileBackgroundColor { get; }
        Uri ProfileBackgroundImageUrl { get; }
        bool ProfileBackgroundTile { get; }
        Uri ProfileImageUrl { get; }
        Uri ProfileBannerUrl { get; }
        Color ProfileLinkColor { get; }
        Color ProfileSidebarBorderColor { get; }
        Color ProfileSidebarFillColor { get; }
        Color ProfileTextColor { get; }
        bool ProfileUseBackgroundImage { get; }
        bool HasExtendedProfile { get; }
        bool DefaultProfile { get; }
        bool DefaultProfileImage { get; }
        bool Following { get; }
        bool FollowRequestSent { get; }
        bool Notifications { get; }
        string TranslatorType { get; }
        bool Suspended { get; }
        bool NeedsPhoneVerification { get; }
    }
}
