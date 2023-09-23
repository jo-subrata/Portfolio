package password_manager;

import java.io.Serializable;
import java.util.Vector;

public class UserData implements Serializable {

	private String email;
	private String password;
	private Vector<WebData> website_datas = new Vector<WebData>();

	public UserData(String email, String password) {

		this.email = email;
		this.password = password;
	}

	public String getEmail() {
		return this.email;
	}

	public String getPassword() {
		return this.password;
	}

	public Vector<WebData> getWebsiteDatas() {
		return this.website_datas;
	}

	public boolean does_web_data_exist(String webName) {
		for (int i = 0; i < website_datas.size(); i++) {
			if (website_datas.get(i).GetWebName().equals(webName)) {
				return true;

			}

		}
		return false;

	}

	public void delete_website(String webName) {

		for (int i = 0; i < website_datas.size(); i++) {
			// just return after delete, since we assume
			// there cannot be duplicate webname in the list
			if (website_datas.get(i).GetWebName().equals(webName)) {
				website_datas.remove(i);
				return;

			}

		}

	}

	public void add_website_data(WebData webData) {
		this.website_datas.add(webData);

	}

}
