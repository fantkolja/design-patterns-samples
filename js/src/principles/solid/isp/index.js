function showInvitationToast(user) {
  return prompt(`${user.name} is inviting you`);
}

showInvitationToast({ name: 'name' });