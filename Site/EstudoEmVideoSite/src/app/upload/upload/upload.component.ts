import { HttpClient, HttpEventType, HttpProgressEvent } from '@angular/common/http';
import { Component, EventEmitter, OnInit, Output } from '@angular/core';

@Component({
  selector: 'app-upload',
  templateUrl: './upload.component.html',
  styleUrls: ['./upload.component.css']
})
export class UploadComponent implements OnInit {

  nomeArquivo : string = "";
  descricao : string = "";
  public progress: number=0;
  public message: string = "";
  @Output() public onUploadFinished = new EventEmitter();

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
  }

  OnChange(event: any){
    console.log(event);
    const selectElement =<FileList>event.srcElement.files;
    console.log( selectElement);
    console.log('   Nome: ', selectElement[0].name);
    console.log('Tamanho: ', selectElement[0].size);
    console.log('   Tipo: ', selectElement[0].type);
    console.log('   buffer: ', selectElement[0].arrayBuffer());
    const elemento = selectElement[0].arrayBuffer();
    var reader = new FileReader();

    reader.addEventListener('load', event => {
        this.createVideo(selectElement[0].arrayBuffer());
    }, false);

    reader.readAsArrayBuffer(event);

  }

  public uploadFile = (files: any) => {
    if (files.length === 0) {
      return;
    }
    let fileToUpload = <File>files[0];
    const formData = new FormData();
    formData.append('file', fileToUpload, fileToUpload.name);
    this.http.post('https://localhost:5001/api/upload', formData, {reportProgress: true, observe: 'events'})
      .subscribe((event : HttpProgressEvent)  => {
        if (event.type === HttpEventType.UploadProgress)
          this.progress = Math.round(100 * event.loaded / event.total);
        else if (event.type === HttpEventType.Response) {
          this.message = 'Upload success.';
          this.onUploadFinished.emit(event.body);
        }
      });
  }


async AJAXSubmit(oFormElement : any) {

  //oFormElement[0].files[0].name = nomeArquivo;

  //if (nomeArquivo != oFormElement[0].files[0].name) {
  //    oFormElement[0].files[0].name(nomeArquivo);
  //    console.log(oFormElement[0].files[0].name);
  //}

  var formData = new FormData(oFormElement);

  try {
      var cook = this.getCookie('RequestVerificationToken');
      const response = await fetch(oFormElement.action, {
          method: 'POST',
          headers: {
              'RequestVerificationToken': cook,
              'descicaoVideo': this.descricao,
              'nome': this.nomeArquivo
          },
          body: formData
      }).then((e) => {
          console.log(e);
          console.log(e.json);
          console.log(e.body);
          console.log(e.bodyUsed);
          console.log(e.arrayBuffer);

      });
      console.log(response);
      //oFormElement.elements.namedItem("result").value =
        //  'Result: ' + response.status + ' ' + response.statusText + ' ' + response.text;

      console.log(response);

  } catch (error) {
      console.log('Error:', error);
  }
}

 getCookie(nome : string) :any  {
  var value = "; " + document.cookie;
  const parts = value.split("; " + nome + "=");
  if (parts.length == 2)
    return parts.pop()?.split(';').shift();
}

   createVideo(data: any) {
    const video: any = document.getElementById("video");
    const mediaSource = new MediaSource();
    const url = URL.createObjectURL(mediaSource);
    video.src = url;

    mediaSource.addEventListener('sourceopen', () => {
        var mimeCodec = 'video/mp4; codecs=avc1.42E01E, mp4a.40.2';
        var sourceBuffer = mediaSource.addSourceBuffer(mimeCodec);

        sourceBuffer.appendBuffer(data);

        sourceBuffer.addEventListener('updateend', () => {
            // triggers oncanplay
            mediaSource.endOfStream();

            video.oncanplay = () => {
                video.play();
            }
        });
    });
 }
}
