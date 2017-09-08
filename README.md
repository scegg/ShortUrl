# ShortUrl

Short url generator with no database required.

Language: C#

Platform: ASP.Net 4.7

See the [change log](CHANGELOG.md) for changes and road map.

## Features

- No database required.
- Multiple host name supported.

## Install

1 Edit DefaultSite setting in web.config:
	When this site is access by an unknown host, the browser will be redirected to this site.
	
2 Create Setting.*.txt in the root folder.

	2.1 Copy file from Setting.localhost.txt to new name. * is the host name of your web site, like Setting.www.google.com.txt.
	
	2.2 All settings of this file can be changed later online.
	
	2.3 Each host need a dedicated file.

3 Upload files to server, including: Setting.*.txt, Short.ashx, Web.config, bin folder and its contents.

4 Access your site url with $$$$Manage$$$$ to setup. e.g. http://MySite.com/$$$$Manage$$$$

## Setup Page
Default: The default redirect url. When the key cannot be recognized, the request will be redirected to this url.

Reload: The key for reloading setting file from disk to memory.

Manage: The key for accessing manage page. You should change this setting ASAP and keep this string safe for yourself only.

These settings above cannot be empty or spaces only.

Click Save button below this table after you change these settings.

Records:

Add/Change: Add or change a key value mapping. If the value is empty, the record with the same key will be deleted.

Delete (Checkbox): Check to delete the record in the same line.

Save button below this table: Add, change or delete records.

## For user
When a user access your site by a host name with no key or a key not matched to any rules below, it will be redirected to the Default address of this host name.

If the setting file of the host name cannot be found, it will be redirected to the address set in Web.Config.

When the key is matched with Reload setting, ShortUrl will reload the setting file from disk and reply OK.

When the key is matched with Manage setting, it will go to the setup page. CAUTION: You need to protect this key and access. Accessing setup page with HTTPS is recommended.

When the key is matched with the key of any records, it will be redirected to the value of the matched record.

## License
[MIT](LICENSE)
