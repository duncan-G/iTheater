using Slugify;

namespace Server.Helpers {
    public class GeneralHelpers {

        private static SlugHelper _slugger = new SlugHelper ();
        public static void CreatePasswordHash (string password, out byte[] passwordHash, out byte[] salt) {
            using (var hmac = new System.Security.Cryptography.HMACSHA512 ()) {
                salt = hmac.Key;
                passwordHash = hmac.ComputeHash (System.Text.Encoding.UTF8.GetBytes (password));
            }
        }

        public static bool VerifyPasswordHash (string password, byte[] storedHash, byte[] storedSalt) {
            using (var hmac = new System.Security.Cryptography.HMACSHA512 (storedSalt)) {
                var computedHash = hmac.ComputeHash (System.Text.Encoding.UTF8.GetBytes (password));
                for (int i = 0; i < computedHash.Length; i++) {
                    if (computedHash[i] != storedHash[i]) return false;
                }
            }
            return true;
        }

        public static string Slugify (string name, int uniqueId) {
            return _slugger.GenerateSlug (name) + "-" + uniqueId;
        }
    }
}