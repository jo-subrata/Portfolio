package password_manager;

import java.io.Serializable;
public class WebData implements Serializable{
	private String webName;
	private String username;
	private String password;
	private String email;

	WebData(String webName, String username, String password, String email) {
		this.webName = webName;
		this.username = username;
		this.password = password;
		this.email = email;

	}
	public String GetWebName() {
		return webName;
		
	}

	public void displayData() {

		System.out.println("Website Name : " + this.webName);
		System.out.println("Username : " + this.username);
		System.out.println("password : " + this.password);
		System.out.println("email : " + this.email);
		System.out.println("=====================================");
	}

}
