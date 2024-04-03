using Clinic.Identity;
using Microsoft.AspNetCore.Identity;
using System.Data;

namespace Clinic.Forms
{
    public partial class RoleEditForm : Form
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        private IList<string>? userRoles;
        private List<IdentityRole>? allRoles;

        public ApplicationUser? user;

        public RoleEditForm(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;

            StartPosition = FormStartPosition.CenterParent;
            InitializeComponent();
            _roleManager = roleManager;
        }

        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            userRoles = await _userManager.GetRolesAsync(user!);
            allRoles = _roleManager.Roles.ToList();

            listView1.Items.Clear();

            var i = 0;
            foreach (var role in allRoles)
            {
                listView1.Items.Add(role.Name);
                listView1.Items[i++].Checked = userRoles?.Contains(role!.Name!) ?? false;
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var roles = listView1!.CheckedItems.Cast<ListViewItem>().Select(item => item.Text).ToList();

            var addedRoles = roles.Except(userRoles!);
            var removedRoles = userRoles!.Except(roles);

            await _userManager.AddToRolesAsync(user!, addedRoles);
            await _userManager.RemoveFromRolesAsync(user!, removedRoles);

            MessageBox.Show("Роли изменены", "", MessageBoxButtons.OK, MessageBoxIcon.None);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
