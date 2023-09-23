package password_manager;

import java.io.*;
import java.security.InvalidKeyException;
import java.util.Scanner;
import java.util.Vector;
import javax.crypto.Cipher;
import javax.crypto.CipherInputStream;
import javax.crypto.CipherOutputStream;
import javax.crypto.SealedObject;
import javax.crypto.spec.SecretKeySpec;

public class Main {

	public static Scanner scanner = new Scanner(System.in);
	public static GlobalData globalData = new GlobalData();
	// some configurations for saving datas
	public static final String databaseFileName = "database";

	public static void save_data(GlobalData globalData, String file_name, Cipher cipher, SecretKeySpec keySpec) {

		try {
			cipher.init(Cipher.ENCRYPT_MODE, keySpec);
		} catch (InvalidKeyException e) {
			System.out.println("exception while saving data: " + e.getMessage());
		}

		// make a sealed object
		SealedObject sealedObject;
		try {
			sealedObject = new SealedObject(globalData, cipher);
		} catch (Exception e) {
			System.out.println("exception while creating sealed object: " + e.getMessage());
		}
		// TODO: need encryption
		try {
			// initialize file and stream output
			FileOutputStream fileStream = new FileOutputStream(file_name);
			CipherOutputStream cipherOutputStream = new CipherOutputStream(new BufferedOutputStream(fileStream),
					cipher);
			ObjectOutputStream objOutputStream = new ObjectOutputStream(cipherOutputStream);

			// write the class
			objOutputStream.writeObject(globalData);

			// close up the open stream
			objOutputStream.close();
			fileStream.close();
			cipherOutputStream.close();

		}

		catch (IOException ex) {
			System.out.println("exception while saving data: " + ex.getMessage());
		}

	}

	public static GlobalData load_data(String file_name, Cipher cipher, SecretKeySpec keySpec) {
		GlobalData loadedData = new GlobalData();

		try {
			cipher.init(Cipher.DECRYPT_MODE, keySpec);
		} catch (InvalidKeyException e) {
			System.out.println("exception while loading data: " + e.getMessage());
		}

		// make a sealed object
		SealedObject sealedObject;
		try {

			FileInputStream fileInputStream = new FileInputStream(file_name);
			CipherInputStream cipherInputStream = new CipherInputStream(new BufferedInputStream(fileInputStream),
					cipher);

			ObjectInputStream objInputStream = new ObjectInputStream(cipherInputStream);
			// Method for deserialization of object
			// get sealed object from thhe file
			// ================= prev method ===========================
			// this gives me an error saying i cannot cast to sealedObject
			// sealedObject = (SealedObject) objInputStream.readObject();

			// decrypt using the cypher object
			// loadedData = (GlobalData) sealedObject.getObject(cipher);
			// =========================================================
			loadedData = (GlobalData) objInputStream.readObject();

			// close streams
			objInputStream.close();
			fileInputStream.close();
			cipherInputStream.close();
		} catch (IOException ex) {
			ex.printStackTrace();

		} catch (ClassNotFoundException e) {
			// handle when class is not found
			// when doing readObject
			e.printStackTrace();
		} catch (Exception e) {
			e.printStackTrace();

		}
		// everything looks okay,
		return loadedData;

	}

	public static void on_register() {
		UtilCheck.clear_screen();
		System.out.println("Register Menu");
		// email input
		String email = "";
		do {
			System.out.print("Email: ");
			email = scanner.nextLine();
			if (UtilCheck.is_email_valid(email)) {
				break;
			}
			System.out.println("Email is not valid");

		} while (true);

		if (globalData.has_email(email)) {
			System.out.println("Email already registered");
			// TODO: error print email,
			return;
		}

		// password input
		// TODO: add input mask?
		String password = "";
		do {
			System.out.print("password : ");
			password = scanner.nextLine();
			if (UtilCheck.is_password_valid(password)) {
				break;
			}
			System.out.println("password is not valid");

		} while (true);

		System.out.print("confirm password : ");
		String confirmpassword = scanner.nextLine();
		if (!confirmpassword.equals(password)) {
			System.out.println("Password doesn't matched");
			return;
		}
		// init
		UserData data = new UserData(email, password);
		// add to our data
		globalData.add_user(data);

	}

	public static void on_login() {
		System.out.println("Login Menu");
		// email input
		String email = "";
		System.out.print("Email: ");
		email = scanner.nextLine();

		if (!globalData.has_email(email)) {
			System.out.println("Email hasn't been registered yet");
			return;
		}

		// input password
		String password = "";
		System.out.print("password: ");
		password = scanner.nextLine();

		if (!globalData.check_user_pass(email, password)) {
			System.out.println("password is invalid");
			return;

		}

		System.out.println("u are logged in");
		// get user that has logged in
		UserData user = globalData.get_user(email);
		LoginMenu.login_Menu(user);

	}

	public static void on_delete() {
		String email = "";
		String password = "";
		int choice;

		// User inputs email
		System.out.print("Email to be deleted: ");
		email = scanner.nextLine();
		if (!globalData.has_email(email)) {
			// If email doesn't exist user returns to the main menu
			System.out.println("Email hasn't been registered yet");
			return;
		}

		// System.out.println("Are you sure you want to delete the account? (1 - Yes | 2
		// - No)");
		// choice = scanner.nextInt();

		choice = 1;
		if (choice == 1) {
			// User inputs password for account deletion
			System.out.print("Enter your account password to proceed with deletion :");
			password = scanner.nextLine();
			if (!globalData.check_user_pass(email, password)) {
				System.out.println("password is invalid");
				return;

			}
			// Get email index
			int index = globalData.get_index(email);
			System.out.println("Deleting account...");
			globalData.delete_user(index);
			System.out.println("Account successfully deleted!");
		} else {
			return;
		}

	}

	public static void intro() {
		System.out.println("Welcome user, to our password manager");

	}

	public static void unit_test() {
		/*
		 * eclipse doesn't enable assert by default
		 * 
		 * to enable assert go to Window->Preferences -> Java and installed JRES click
		 * edit... in default VM arguments add "-ea" options
		 * 
		 */

		System.out.println("testing app....");
		// valid email
		assert true == UtilCheck.is_email_valid("test@gmail.com");
		;
		assert true == UtilCheck.is_email_valid("nicho@gmail.com");
		;
		assert true == UtilCheck.is_email_valid("IHateJavaSoMuch@gmail.com");
		;
		assert true == UtilCheck.is_email_valid("KILLMEPLS12345421@gmail.com");
		;
		// invalid email
		assert false == UtilCheck.is_email_valid("andrewtanen@@gmail.com");
		;
		assert false == UtilCheck.is_email_valid("andrewtanen@@gmailcom");
		;
		assert false == UtilCheck.is_email_valid("@gmailcom");
		;
		assert false == UtilCheck.is_email_valid("@gmailcom");
		;
		assert false == UtilCheck.is_email_valid("andrewtanen@gmail.com@");
		;

		System.out.println("testing done");

	}

	public static void main(String[] arg) {

		/**/
		intro();
		unit_test();

		// ============================ initialize encryption ===============
		SecretKeySpec keySpec = new SecretKeySpec(new byte[] { 0x00, 0x05, 0x22, 0x9, 0xc, 0xe, 0x07 }, "Blowfish");
		Cipher cipher;
		// initialize cipher
		try {
			cipher = Cipher.getInstance("Blowfish");
		} catch (Exception e) {
			System.out.println("Exception when initializing Cipher object");
			return;

		}
		// ==================================================================
		/*
		 * call back when program exits to save the data
		 **/
		Runtime.getRuntime().addShutdownHook(new Thread(new Runnable() {
			public void run() {
				System.out.println("saving data ...");
				save_data(globalData, databaseFileName, cipher, keySpec);
				System.out.println("saving data done");

			}
		}));
		//
		/*
		 * try to load a data
		 */
		File databaseFile = new File(databaseFileName);
		// only load if file exist
		if (databaseFile.exists() && !databaseFile.isDirectory()) {
			globalData = load_data(databaseFileName, cipher, keySpec);

		}
		// ==============================================================

		/* run program as normal */

		while (true) {

			UtilCheck.clear_screen();
			System.out.println("================ Main Menu ==============");
			System.out.println("=========================================");
			System.out.println("1. Register");
			System.out.println("2. Login");
			System.out.println("3. Delete Account");
			System.out.println("4. Exit");
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

				}

			}
			if (n == 1)
				on_register();
			if (n == 2)
				on_login();
			if (n == 3)
				on_delete();
			if (n == 4)
				return;
		}

	}
}
