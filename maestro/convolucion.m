str='holacrayola';
x=double(str);
h=[0.3 .5 .2]
y1=conv2(x,h)
filename = "convolucion.txt"
fid=fopen(filename,"w")

string_array = num2str(y1)
fputs(fid,string_array)
fclose(fid)








