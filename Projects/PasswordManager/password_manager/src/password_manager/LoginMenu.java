package password_manager;

import java.util.Scanner;
import java.util.Vector;

public class LoginMenu {
	public static Scanner scanner = new Scanner(System.in);

	public static void Add_Password(UserData userData) {
		System.out.println("Add Password");
		String webName = "";
		String username = "";
		String password = "";
		String email = "";

		// input from user
		System.out.print("Website Name :");
		webName = scanner.nextLine();
		System.out.print("Username :");
		username = scanner.nextLine();
		System.out.print("Password :");
		password = scanner.nextLine();
		System.out.print("Email :");
		email = scanner.nextLine();
		// create WebData
		WebData webData = new WebData(webName, username, password, email);
		userData.add_website_data(webData);
		System.out.println("Website information has been added!");
	}

	public static void DeletePassword(UserData userData) {
		System.out.println("Deleting password... ");
		String webName = "";

		// input from user
		System.out.print("Website Name To Delete :");
		webName = scanner.nextLine();

		if (!userData.does_web_data_exist(webName)) {

			System.out.println("The web name you gave isn't contained in the list");
			System.out.println("Cannot delete data");
			return;
		}
		userData.delete_website(webName);
		System.out.println("Website " + webName + "has been deleted");

	}

	public static void ViewList(UserData userData) {
		Vector<WebData> website_datas = userData.getWebsiteDatas();

		for (int i = 0; i < website_datas.size(); i++) {
			website_datas.get(i).displayData();
		}

	}

	public static void login_Menu(UserData userData) {

		while (true) {

			UtilCheck.clear_screen();
			System.out.println("================ Account Menu ==============");
			System.out.println("============================================");
			System.out.println("1. Add Password");
			System.out.println("2. View List");
			System.out.println("3. Delete Website");
			System.out.println("4. Logout");
			
			System.out.print("your choice: ");
			int n = 0;
			String str_input = scanner.nextLine();
			// if string is not numeric -> invalid
			if (!UtilCheck.is_numeric(str_input)) {
				System.out.println("Invalid input, input must be numeric");
				continue;
			} else {
				// convert string to number
				n = Integer.parseInt(str_input);
				if (n < 1 || n > 4) {
					System.out.println("Invalid input, must be between 1 to 3");
					continue;

				}

			}
			if (n == 1)
				Add_Password(userData);
			if (n == 2)
				ViewList(userData);
			if (n == 3)
				DeletePassword(userData);
			if (n == 4)
				return;
		}
	}
}
