namespace ACME.LearningCenterPlatform.API.Publishing.Domain.Model.ValueObjects;

/// <summary>
/// Publishable Interface. I Represent the actions that can be performed on a publishable entity.
/// </summary>
public interface IPublishable
{
    void SendToEdit();
    void SendToApproval();
    void ApproveAndLock();
    void Reject();
    void ReturnToEdit();
}