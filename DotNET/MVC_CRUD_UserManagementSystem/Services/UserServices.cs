using MVC_CRUD_UserManagementSystem.Models;

namespace MVC_CRUD_UserManagementSystem.Services
{
    public static class UserServices
    {
        private static List<UserModel> _users = new List<UserModel>();
        public static List<UserModel> GetAll()
        {
            return _users;
        }
        public static void Add(UserModel model)
        {
            _users.Add(model);
        }
        public static void Update(UserModel model)
        {
            var user = _users.Find(u => u.Id == model.Id);
            user.Name = model.Name;
        }
        public static void Delete(int id)
        {
            var user= _users.Find(u => u.Id == id);
            _users.Remove(user);
        }
    }
}
