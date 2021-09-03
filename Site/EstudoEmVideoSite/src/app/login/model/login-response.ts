import { Notification } from "src/app/util/model/notification";

export class LoginResponse{
  Id: string = "";
  ContaAtiva : boolean = false;
  Logado : boolean = false;
  Login: string = "";
  TermoDeAceite  : boolean = false;
  HasNotification :boolean = false;
  Notifications: Notification[] = []
}
