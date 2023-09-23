package password_manager;

import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class UtilCheck {

	public static boolean is_numeric(String str_input) {
		try {
			Double.parseDouble(str_input);
			return true;
		} catch (NumberFormatException e) {
			return false;
		}
	}

	public static void clear_screen() {
//		System.out.print("\033[H\033[2J");
//		System.out.flush();
	}

	public static boolean is_email_valid(String email) {
		/*
		 * 
		 * ^ asserts position at start of a line Match a single character present in the
		 * list below [A-Z0-9._%+-] + matches the previous token between one and
		 * infinite only return as needed
		 * 
		 * A-Z match all from A-Z 0-9 matches a number between 0-9 (all possible number)
		 * ._%+- matches a single character in the list ._%+- (case sensitive) for email
		 * this is allowed
		 * 
		 * @ matches the character @ the second bracket is the same as the prev bracket
		 * except there is an addition
		 * 
		 * .- only allow dot or strip like for .com, .id or etc
		 * 
		 * . matches any character except for new line
		 * 
		 * [A-Z] {2,6} matches the previous take between 2 - 6 chars can be like com,
		 * id, org or etc
		 * 
		 */
		Pattern email_pattern = Pattern.compile("^[A-Z0-9._%+-]+@[A-Z0-9.-]+\\.[A-Z]{2,6}$", Pattern.CASE_INSENSITIVE);
		boolean is_valid = email_pattern.matcher(email).find();

		return is_valid;

	}

	public static boolean is_password_valid(String pass) {
		// TODO: add more check
		if (pass.length() < 5)
			return false;
		return true;

	}

}
