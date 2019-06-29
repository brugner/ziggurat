namespace Corlib.Core.Domain
{
   public class Parameter
   {
      public int Id { get; set; }
      public string GymName { get; set; }
      public string GymAddress { get; set; }
      public int GymCityId { get; set; }
      public string GymPhone { get; set; }
      public string GymEmail { get; set; }
      public string GymFacebook { get; set; }
      public string GymTwitter { get; set; }
      public string GymInstagram { get; set; }
      public string RequiredField { get; set; }
      public string InvalidEmailAddress { get; set; }
      public string EnterAtLeastAPhone { get; set; }
      public string EnterMobilePhoneAreaCode { get; set; }
      public string EnterPhoneNumber { get; set; }
      public string SelectAtLeastOne { get; internal set; }
      public string Skin { get; set; }
      public int SplitContainerMembersVerticalSplitterPosition { get; set; }
      public int SplitContainerMembersHorizontalSplitterPosition { get; set; }
   }
}
