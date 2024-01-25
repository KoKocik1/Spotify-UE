FROM python:3.9.18-alpine

WORKDIR /app

COPY . .

RUN pip install --upgrade pip

RUN pip install -r /app/requirements.txt

CMD ["/usr/local/bin/python", "/app/main.py"]
