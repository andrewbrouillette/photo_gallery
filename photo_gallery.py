import json

A = str(input("Photo Album: "))

int_input = int(A)


with open('photos.json', 'r') as f:
	distros_dict = json.load(f)

for distro in distros_dict:
	if distro['albumId'] == int_input:
		print([distro['id']], distro['title'], distro['url'])

