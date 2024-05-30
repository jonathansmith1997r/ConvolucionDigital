h=[0.3 .5 .2]

DATA = load("-ascii","deconvolucion.txt")



msg=deconv(DATA,h)

char(msg)
